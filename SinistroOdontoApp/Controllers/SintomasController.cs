using Microsoft.AspNetCore.Mvc;
using SinistroOdontoApp.ViewModels;

namespace SinistroOdontoApp.Controllers
{
    public class SintomasController : Controller
    {
        // GET: Sintomas/Identificar
        [HttpGet]
        public IActionResult Identificar()
        {
            return View();
        }

        // POST: Sintomas/Identificar
        [HttpPost]
        public IActionResult Identificar(IdentificarSintomasViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                // Simula a lógica de identificação de sintomas
                viewModel.Resposta = new Models.IdentificarSintomasResponseDto
                {
                    Doenca = "Cárie",
                    Gravidade = "Moderada",
                    Recomendacao = "Consultar um dentista"
                };

                return View(viewModel);
            }
            return View(viewModel);
        }

        // CRUD: Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(IdentificarSintomasViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                // Adicionar a lógica para criar um registro
                return RedirectToAction("Index");
            }
            return View(viewModel);
        }

        // CRUD: Edit
        [HttpGet]
        public IActionResult Edit(int id)
        {
            // Buscar o registro por id e passar para a view
            return View();
        }

        [HttpPost]
        public IActionResult Edit(int id, IdentificarSintomasViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                // Atualizar o registro com base no id
                return RedirectToAction("Index");
            }
            return View(viewModel);
        }

        // CRUD: Delete
        [HttpGet]
        public IActionResult Delete(int id)
        {
            // Lógica para exibir confirmação de exclusão
            return View();
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            // Lógica para excluir o registro
            return RedirectToAction("Index");
        }

        // CRUD: Details
        [HttpGet]
        public IActionResult Details(int id)
        {
            // Buscar detalhes do registro por id
            return View();
        }
    }
}
