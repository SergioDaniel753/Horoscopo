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
            // Arrange=preparación
            int fecha = 27;
            int mes = 3;
            string esperado = "Aries-> No busques pretextos poco creíbles para justificar tus errores. Sé más responsable y hazte cargoLas diferencias de criterio son muy notables.No coinciden en nada, así que por su bien lo mejor es que la relación finalice. de tus desaciertos";
            HoroscopoController Hor = new HoroscopoController();
            // Act=ejecución
            string resultado = Hor.HoroscopoGet(fecha, mes);
            // Assert=verificación
            Assert.AreEqual(esperado, resultado);
        }
        public void TestHoroscop2()
        {
            // Arrange=preparación
            int fecha =21 ;
            int mes = 5;
            string esperado = "Tauro-> Si buscas un consejo, recurre a tu familia. Tus amigos no son del todo objetivos, pero tu familia tiene una visión más amplia.Aparecerán nuevas amistades. Un cambio de ámbito te pondrá en contacto con personas de otra generación, que formarán parte de tu vida.";
            HoroscopoController Hor = new HoroscopoController();
            // Act=ejecución
            string resultado = Hor.HoroscopoPost(fecha, mes);
            // Assert=verificación
            Assert.AreEqual(esperado, resultado);
        }

    }
}