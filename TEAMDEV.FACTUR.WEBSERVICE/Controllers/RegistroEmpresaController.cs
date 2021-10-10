using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TEAMDEV.FACTUR.DATOS;
using TEAMDEV.FACTUR.ENTITY.Parametros;

namespace TEAMDEV.FACTUR.WEBSERVICE.Controllers
{
    [RoutePrefix("api/RegistroEmpresa")]
    public class RegistroEmpresaController : ApiController
    {
        private DAPaises dapaises;
        private DAMoneda damoneda;
        private DATipoImpuesto datimpuesto;
        private DAPorcentaje daporcentaje;
        private DARegistroEmpresa daregistroempresa;

        public RegistroEmpresaController()
        {
            dapaises = new DAPaises();
            damoneda = new DAMoneda();
            datimpuesto = new DATipoImpuesto();
            daporcentaje = new DAPorcentaje();
            daregistroempresa = new DARegistroEmpresa();
        }



        [HttpPost]
        [Route("listarPaises")]
        public IHttpActionResult listarPaises(RegistroEmpresaEN paramss)
        {
            try
            {
                var response = dapaises.listarPaises(paramss);
                return Ok(response);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpPost]
        [Route("listarMoneda")]
        public IHttpActionResult listarMonedas (RegistroEmpresaEN paramss)
        {
            try
            {
                var response = damoneda.listarMoneda(paramss);
                return Ok(response);
            }
            catch (Exception ex)
                
            {

                throw ex;
            }
        }

        [HttpPost]
        [Route("listarTImpuesto")]
        public IHttpActionResult listarTImpuesto(RegistroEmpresaEN paramss)
        {
            try
            {
                var response = datimpuesto.listarTImpuesto(paramss);
                return Ok(response);
            }
            catch (Exception ex)

            {

                throw ex;
            }
        }


        [HttpPost]
        [Route("listarPorcentaje")]
        public IHttpActionResult listarPorcentaje(RegistroEmpresaEN paramss)
        {
            try
            {
                var response = daporcentaje.listarPorcentaje(paramss);
                return Ok(response);
            }
            catch (Exception ex)

            {

                throw ex;
            }
        }

        [HttpPost]
        [Route("validarRegistro")]
        public IHttpActionResult validarRegistro(RegistroEmpresaEN paramss)
        {
            try
            {
                var response = daregistroempresa.validarRegistro(paramss);
                return Ok(response);
            }
            catch (Exception ex)

            {

                throw ex;
            }
        }


        [HttpPost]
        [Route("insertarEmpresa")]
        public IHttpActionResult insertarEmpresa(RegistroEmpresaEN paramss)
        {
            try
            {
                var response = daregistroempresa.insertarEmpresa(paramss);
                return Ok(response);
            }
            catch (Exception ex)

            {

                throw ex;
            }
        }
        [HttpPost]
        [Route("insertarUserAdminEmpresa")]
        public IHttpActionResult insertarUserAdminEmpresa(RegistroEmpresaEN paramss)
        {
            try
            {
                var response = daregistroempresa.insertarUserAdminEmpresa(paramss);
                return Ok(response);
            }
            catch (Exception ex)

            {

                throw ex;
            }
        }
    }

}
