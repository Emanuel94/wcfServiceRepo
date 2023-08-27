using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFServiceMedico.Class;
using WCFServiceMedico.Models;

namespace WCFServiceMedico
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceHospital" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceHospital.svc or ServiceHospital.svc.cs at the Solution Explorer and start debugging.
    public class ServiceHospital : IServiceHospital
    {

        public IEnumerable<FormaFarmaceuticaCLS> listarFormaceutica()
        {
            IEnumerable<FormaFarmaceuticaCLS> listaFarmaceutica = new List<FormaFarmaceuticaCLS>();

            try
            {
                using (var db = new MedicoEntities())
                {
                    listaFarmaceutica = db.FormaFarmaceutica
                        .Where(p => p.BHABILITADO ==1)
                        .Select(p => new FormaFarmaceuticaCLS
                        {
                            iidFormafarmaceutica = p.IIDFORMAFARMACEUTICA,
                            Nombre = p.NOMBRE,

                        }).ToList();
                    return listaFarmaceutica;
                }
            }
            catch (Exception ex)
            {
                listaFarmaceutica = null;
                return listaFarmaceutica;
            }

        }

        public IEnumerable<MedicamentoCLS> listarMedicamento()
        {
            IEnumerable<MedicamentoCLS> listarMedicamento = new List<MedicamentoCLS>();
            try
            {
                using (var db = new MedicoEntities())
                {
                    listarMedicamento = (from medicamento in db.Medicamento
                                         join formaFarmaceutica in db.FormaFarmaceutica
                                         on medicamento.IIDFORMAFARMACEUTICA equals
                                         formaFarmaceutica.IIDFORMAFARMACEUTICA
                                         select new MedicamentoCLS
                                         {
                                             IIdMedicamento = medicamento.IIDMEDICAMENTO,
                                             nombre = medicamento.NOMBRE,
                                             Precio = (decimal)medicamento.PRECIO,
                                             nombreFormaFarmaceutica = formaFarmaceutica.NOMBRE,
                                             concentracion = medicamento.CONCENTRACION,
                                             presentacion = medicamento.PRESENTACION,
                                             habilitado = (int)medicamento.BHABILITADO,
                                             stock = (int)medicamento.STOCK

                                         }).ToList();
                }
            }
            catch (Exception)
            {
                listarMedicamento = null;
                throw;
            }
            return listarMedicamento;
        }


        public MedicamentoCLS recuperarMedicamento(int iiMedicamento)
        {
            MedicamentoCLS medicamento = new MedicamentoCLS();
            try
            {
                using (var db = new MedicoEntities())
                {
                    Medicamento oMedicamento = db.Medicamento.Where(p => p.IIDMEDICAMENTO == iiMedicamento).First();
                    medicamento.IIdMedicamento = oMedicamento.IIDMEDICAMENTO;
                    medicamento.nombre = oMedicamento.NOMBRE;
                    medicamento.iidFormaFarmaceutica = (int)oMedicamento.IIDFORMAFARMACEUTICA;
                    medicamento.Precio = (decimal)oMedicamento.PRECIO;
                    medicamento.stock = (int)oMedicamento.STOCK;
                    medicamento.concentracion = oMedicamento.CONCENTRACION;
                    medicamento.presentacion = oMedicamento.PRESENTACION;

                }
            }
            catch (Exception)
            {
                medicamento = null;

            }
            return medicamento;
        }

        public int agregarYActualizarMedicamento(MedicamentoCLS medicamento)
        {
            int result = 0;
            try
            {
                using (var db = new MedicoEntities())
                {


                    if (medicamento.IIdMedicamento == 0)
                    {
                        Medicamento omedicamento = new Medicamento();
                        omedicamento.IIDMEDICAMENTO = medicamento.IIdMedicamento;
                        omedicamento.NOMBRE = medicamento.nombre;
                        omedicamento.PRECIO = medicamento.Precio;
                        omedicamento.STOCK = medicamento.stock;
                        omedicamento.IIDFORMAFARMACEUTICA = medicamento.iidFormaFarmaceutica;
                        omedicamento.CONCENTRACION = medicamento.concentracion;
                        omedicamento.PRESENTACION = medicamento.presentacion;
                        omedicamento.BHABILITADO = 1;
                        db.Medicamento.Add(omedicamento);
                        db.SaveChanges();
                        result = 1;
                    }
                    else
                    {
                        Medicamento oMedicamento = db.Medicamento.Where(p => p.IIDMEDICAMENTO == medicamento.IIdMedicamento).First();
                            oMedicamento.IIDMEDICAMENTO = medicamento.IIdMedicamento;
                            oMedicamento.NOMBRE = medicamento.nombre;
                            oMedicamento.PRECIO = medicamento.Precio;
                            oMedicamento.STOCK = medicamento.stock;
                            oMedicamento.IIDFORMAFARMACEUTICA = medicamento.iidFormaFarmaceutica;
                            oMedicamento.CONCENTRACION = medicamento.concentracion;
                            oMedicamento.PRESENTACION = medicamento.presentacion;

                        db.SaveChanges();
                        result = 1;
                    }
                }
            }
            catch (Exception)
            {

                result = 0;
            }
            return result;
        }
        public int eliminarMeidcamento(int iidMedicamento)
        {
            int result = 0;
            try
            {
                using (var db = new MedicoEntities())
                {
                    Medicamento oMedicamento = db.Medicamento.Where(m => m.IIDMEDICAMENTO == iidMedicamento).First();
                    oMedicamento.BHABILITADO = 0;
                    db.SaveChanges();
                    result = 1;
                }

            }
            catch (Exception ex)
            {
                result = 0;
                throw;
            }
            return result;

        }

    }
}
