using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Tarea_9.Context;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Tarea_9.Models;
using Tarea_9.EmailHandler;

namespace Tarea_9.Controllers
{
    public class CitasController : Controller
    {
        private readonly CitaContext context;
        private readonly  Gmailsender _emailSender;
        public CitasController(CitaContext context, Gmailsender emailSender)
        {
            this.context = context;
            this._emailSender = emailSender;
            
        }

        public IActionResult Index(){
            return View();
        }

        public async Task<IActionResult> Create(Cita cita){

            if(ModelState.IsValid){
               var citaEncontrada = await context.Citas.FirstOrDefaultAsync(x => x.correoElectronico == cita.correoElectronico);
                 if(citaEncontrada != null){
                     TempData["solicitud"] = "Usted ya ha solicitado una vacuna";
                     return RedirectToAction("Index");
                 }
                 context.Add(cita);
                 await context.SaveChangesAsync();
                  var message = new Message(new string[] { cita.correoElectronico}, "Mensaje de pampara" , $"{cita.apellido}, {cita.cedula},{cita.telefono}, {cita.fechaNacimiento}, {cita.tipoSangre}, {cita.provincia}, {cita.direccion}, {cita.covid}, {cita.justificacion}");
                  Console.WriteLine(message);
                 await _emailSender.SendMailAsync(message);
            }

            return RedirectToAction("Index");
           

            

        }

        public IActionResult Privacy()
        {
            return View();
        }

      
    }
}
