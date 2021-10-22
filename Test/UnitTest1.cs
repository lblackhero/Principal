using Equitool.Data;
using EquiTool.Aplication;
using EquiTool.Domain;
using EquiTool.infrastructure;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        private readonly Mock<IFacturacion> _IFacturacion = new Mock<IFacturacion>();

        public UnitTest1()
        {

        }

        //[TestMethod]

        //public void AddWhenReturnTrue_Facturacion()
        //{

        //    fac_facturacion Mock = new fac_facturacion() { Aspnet_UserId = "", facb_estado = true, facc_descripcion = "", facc_repositorio = "" };

        //    var returnTrue = _IFacturacion.Object.AddFacturacion(Mock);


        //    Assert.IsFalse(returnTrue);
        //}

        [TestMethod]
        public void AddWhenReturnFalse_Facturacion()
        {
            fac_facturacion Mock = new fac_facturacion() { Aspnet_UserId = "", facb_estado = true, facc_descripcion = "", facc_repositorio = "" };

            var returnFalse = _IFacturacion.Object.AddFacturacion(Mock);


            Assert.IsFalse(returnFalse);
        }
    }
}
