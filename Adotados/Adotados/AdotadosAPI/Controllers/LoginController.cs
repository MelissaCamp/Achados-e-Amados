using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using AdotadosAPI.Data;
using AdotadosDTO;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace AdotadosAPI.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("MyPolicy")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly AdotadosAPIContext _context;

        public LoginController(AdotadosAPIContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Login([FromBody] LoginDTO login)

        {
            //procurar pelo usuario no banco
            ClienteDTO? cliente = _context.ClienteDTO.FirstOrDefault(user => user.Email == login.Email && user.Senha == login.Senha);
            FuncionarioDTO? funcionario = _context.FuncionarioDTO.FirstOrDefault(user => user.Email == login.Email && user.Senha == login.Senha);

            if (cliente != null)
            {
                var claims = new[]
                {
                   new Claim("IdCliente", cliente.IdCliente.ToString()),
                   new Claim(ClaimTypes.Name, cliente.Nome ?? ""),
                   new Claim(ClaimTypes.Role, "Admin")
               };

                string secretKey = "6Thc6smwkRQeFSOGGDDplGZeirGPgBULaUe5EBCfg0xo4YA1OBkuudHiP2T41eg7SmE58hvrxB9CWYgwk9xbdbpEqsYsdMMaIvSey3aea8d2EtWV9C8tGJlmqfROgvZS";

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken(
                    issuer: "*",
                    audience: "*",
                    claims: claims,
                    expires: DateTime.Now.AddHours(1),
                    signingCredentials: creds
                );

                return Ok(new { token = new JwtSecurityTokenHandler().WriteToken(token), IdCliente = cliente.IdCliente });
            }
            else if (funcionario != null)
            {
                var claims = new[]
                { 
                   new Claim("IdFuncionario", funcionario.IdFuncionario.ToString()),
                   new Claim(ClaimTypes.Name, funcionario.Nome ?? ""),
                   new Claim(ClaimTypes.Role, "Admin")
               };

                string secretKey = "6Thc6smwkRQeFSOGGDDplGZeirGPgBULaUe5EBCfg0xo4YA1OBkuudHiP2T41eg7SmE58hvrxB9CWYgwk9xbdbpEqsYsdMMaIvSey3aea8d2EtWV9C8tGJlmqfROgvZS";

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken(
                    issuer: "*",
                    audience: "*",
                    claims: claims,
                    expires: DateTime.Now.AddHours(1),
                    signingCredentials: creds
                );

                return Ok(new { token = new JwtSecurityTokenHandler().WriteToken(token) });
            }

            else
            {
                return Unauthorized("Credenciais inválidas");
            }


        }
    }
}
