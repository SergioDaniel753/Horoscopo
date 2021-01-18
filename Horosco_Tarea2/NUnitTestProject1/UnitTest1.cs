using Horosco_Tarea2.Controllers;
using NUnit.Framework;

namespace NUnitTestHoroscopo
{
    public class TestHoroscopo
    {
        public object HoroscopoController { get; private set; }

        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void TestHoroscop()
        {
            // Arrange=preparaci�n
            int fecha = 27;
            int mes = 3;
            string esperado = "Aries-> No busques pretextos poco cre�bles para justificar tus errores. S� m�s responsable y hazte cargoLas diferencias de criterio son muy notables.No coinciden en nada, as� que por su bien lo mejor es que la relaci�n finalice. de tus desaciertos";
            HoroscopoController Hor = new HoroscopoController();
            // Act=ejecuci�n
            string resultado = Hor.HoroscopoGet(fecha, mes);
            // Assert=verificaci�n
            Assert.AreEqual(esperado, resultado);
        }
        public void TestHoroscop2()
        {
            // Arrange=preparaci�n
            int fecha =21 ;
            int mes = 5;
            string esperado = "Tauro-> Si buscas un consejo, recurre a tu familia. Tus amigos no son del todo objetivos, pero tu familia tiene una visi�n m�s amplia.Aparecer�n nuevas amistades. Un cambio de �mbito te pondr� en contacto con personas de otra generaci�n, que formar�n parte de tu vida.";
            HoroscopoController Hor = new HoroscopoController();
            // Act=ejecuci�n
            string resultado = Hor.HoroscopoPost(fecha, mes);
            // Assert=verificaci�n
            Assert.AreEqual(esperado, resultado);
        }

    }
}