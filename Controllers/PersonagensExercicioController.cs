using Microsoft.AspNetCore.Mvc;
using RpgApi.Models;
using RpgApi.Models.Enuns;

namespace RpgApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class PersonagensExercicioController : ControllerBase
    {
         private static List<Personagem> personagens = new List<Personagem>()
        {
            //Colar os objetos da lista do chat aqui
            new Personagem() { Id = 1, Nome = "Frodo", PontosVida=100, Forca=17, Defesa=23, Inteligencia=33, Classe=ClasseEnum.Cavaleiro},
            new Personagem() { Id = 2, Nome = "Sam", PontosVida=100, Forca=15, Defesa=25, Inteligencia=30, Classe=ClasseEnum.Cavaleiro},
            new Personagem() { Id = 3, Nome = "Galadriel", PontosVida=100, Forca=18, Defesa=21, Inteligencia=35, Classe=ClasseEnum.Clerigo },
            new Personagem() { Id = 4, Nome = "Gandalf", PontosVida=100, Forca=18, Defesa=18, Inteligencia=37, Classe=ClasseEnum.Mago },
            new Personagem() { Id = 5, Nome = "Hobbit", PontosVida=100, Forca=20, Defesa=17, Inteligencia=31, Classe=ClasseEnum.Cavaleiro },
            new Personagem() { Id = 6, Nome = "Celeborn", PontosVida=100, Forca=21, Defesa=13, Inteligencia=34, Classe=ClasseEnum.Clerigo },
            new Personagem() { Id = 7, Nome = "Radagast", PontosVida=100, Forca=25, Defesa=11, Inteligencia=35, Classe=ClasseEnum.Mago }
        };

        [HttpGet("GetByNome/{nome}")]
        public IActionResult Get(string nome)
        {
            List<Personagem> listaFinal = personagens.FindAll(n => n.Nome.Contains(nome));
            
            if(listaFinal.Count == 0)
                return NotFound("Nome não encontrado");

                return Ok(listaFinal); 
        }

        [HttpPost("PostValidacao")]
        public IActionResult PostValidacao(Personagem novoPersonagem)
        {
            if(novoPersonagem.Inteligencia > 30 || novoPersonagem.Defesa < 10)
            {
                return BadRequest("Inteligência não pode ser maior que 30 ou Defesa menor que 10");
            }

            personagens.Add(novoPersonagem);
            return Ok(personagens);
        }

        [HttpPost("PostValidacaoMago")]
        public IActionResult PostValidacaoMago(Personagem novoPersonagem)
        {
            if(((int)novoPersonagem.Classe == 2))
            {
                if(novoPersonagem.Inteligencia < 35)
                {
                    return BadRequest("Inteligência não pode ser menor que 35");
                }
            }

            personagens.Add(novoPersonagem);
            return Ok(personagens);
        }

        [HttpGet("GetClerigoMago")]
        public IActionResult GetClerigoMago()
        {
            List<Personagem> listaFinal = personagens.FindAll(p => p.Classe != ClasseEnum.Cavaleiro).OrderBy(x => x.PontosVida).ToList();
            return Ok(listaFinal);
        }

        [HttpGet("GetEstatisticas")]
        public IActionResult GetEstatisticas()
        {
            return Ok("Quantidade de personagens: " + personagens.Count + "\n" +
            "Soma da Inteligência " + personagens.Sum(p => p.Inteligencia));
        }

        [HttpGet("GetByClasse/{id}")]
        public IActionResult GetByClasse(int id)
        {
            switch(id)
            {
                case 1:
                    List<Personagem> listaCavaleiro = personagens.FindAll(p => p.Classe == ClasseEnum.Cavaleiro);
                    return Ok(listaCavaleiro);
                case 2:
                    List<Personagem> listaMago = personagens.FindAll(p => p.Classe == ClasseEnum.Mago);
                    return Ok(listaMago);
                case 3:
                    List<Personagem> listaClerigo = personagens.FindAll(p => p.Classe == ClasseEnum.Clerigo);
                    return Ok(listaClerigo);
            }

            return BadRequest("Digite uma id de classe válida");
        }
    }
}