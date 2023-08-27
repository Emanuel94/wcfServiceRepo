using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ConsumiendoWCF.ServiceHospital;

namespace ConsumiendoWCF.Controllers
{
    public class MedicamentoController : Controller
    {
        // GET: Medico
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult listarmedicamentos()
        {

            ServiceHospitalClient oMedicamentos = new ServiceHospitalClient();
            var list = oMedicamentos.listarMedicamento()
                .Where(p => p.habilitado == 1 )
                .Select(
                    p => new
                    {
                        p.IIdMedicamento,
                        p.nombre,
                        p.concentracion,
                        p.nombreFormaFarmaceutica,
                        p.presentacion,
                        p.stock,
                        p.Precio
                    }
                    ).ToList();

            return Json(list, JsonRequestBehavior.AllowGet);

        }

        public JsonResult listarmedicamentosPorNombre(string nombreMedicamento)
        {

            ServiceHospitalClient oMedicamentos = new ServiceHospitalClient();
            var list = oMedicamentos.listarMedicamento()
                .Where(p => p.nombre.ToLower().Contains(nombreMedicamento.ToLower()) && p.habilitado == 1)
                .Select(
                    p => new
                    {
                        p.IIdMedicamento,
                        p.nombre,
                        p.concentracion,
                        p.nombreFormaFarmaceutica,
                        p.presentacion,
                        p.stock,
                        p.Precio
                    }
                    ).ToList();

            return Json(list, JsonRequestBehavior.AllowGet);

        }
        public JsonResult recuperarMedicamento(int idMedicamento)
        {
          
            try
            {
                ServiceHospitalClient servicesHospital = new ServiceHospitalClient();
               var result =  servicesHospital.recuperarMedicamento(idMedicamento);
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (Exception)
            {

                return Json("BadRequest", JsonRequestBehavior.AllowGet);
            }
        }

        public JsonResult listarFormaFarmaceutica()
        {
            try
            {
                ServiceHospitalClient oMedicamentos = new ServiceHospitalClient();
                var list = oMedicamentos.listarFormaceutica().ToList();
                return Json(list, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }

          
        }

        public int agregarYActualizarMedicamento(MedicamentoCLS medicamento)
        {
            int result = 0;
            try
            {
                ServiceHospitalClient hospitalService = new ServiceHospitalClient();

                result = hospitalService.agregarYActualizarMedicamento(medicamento);

            }
            catch (Exception)
            {

                result = 0;
            }
            return result;
        }
        public int eliminarMedicamento(int iidMedicamento)
        {
            int result = 0;

            try
            {
                ServiceHospitalClient hospitalService = new ServiceHospitalClient();

                hospitalService.eliminarMeidcamento(iidMedicamento);

                result = 1;
            }
            catch (Exception)
            {
                result = 0;
            }
            return result;
        }
    }

}