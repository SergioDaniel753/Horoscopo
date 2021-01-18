using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Horosco_Tarea2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HoroscopoController : Controller
    { [HttpGet]
        public string HoroscopoGet(int fecha, int mes)
        {
            if (fecha > 31 || fecha < 1)
            {
                return "Error.Ingresar una fecha con valor establecido";
            }
            if (mes > 12 || mes < 1)
            {
                return "Error.Ingresar el mes con valor establecido";
            }
            if ((fecha >= 21 && mes == 3) || (fecha <= 20 && mes == 4))
            {
                return "Aries-> No busques pretextos poco creíbles para justificar tus errores. Sé más responsable y hazte cargoLas diferencias de criterio son muy notables.No coinciden en nada, así que por su bien lo mejor es que la relación finalice. de tus desaciertos";
            }
            if ((fecha >= 21 && mes == 4) || (fecha <= 20 && mes == 5))
            {
                return "Tauro->Si buscas un consejo, recurre a tu familia. Tus amigos no son del todo objetivos, pero tu familia tiene una visión más amplia.Aparecerán nuevas amistades. Un cambio de ámbito te pondrá en contacto con personas de otra generación, que formarán parte de tu vida.";
            }
            if ((fecha >= 21 && mes == 5) || (fecha <= 21 && mes == 6))
            {
                return "Geminis-> Sucederá algo que te hará pensar que quienes dicen ser tus amigos no son tan sinceros como parecen. Analízalos mejor.Lograrás las cosas a tu manera, de la forma que te las habías propuestos. Tu intransigencia es imbatible, sigue por ese camino.";
            }
            if ((fecha >= 22 && mes == 6) || (fecha <= 22 && mes == 7))
            {
                return "Cancer-> Hoy sientes que nada te conforma y te molesta el estar rodeado de gente. Relájate y regálate un tiempo para ti cuando llegues a tu casa.Trata de mantener una alimentación equilibrada si no quieres terminar haciendo dieta. Beber mucha agua le hará bien a tu piel.";
            }
            if ((fecha >= 23 && mes == 7) || (fecha <= 23 && mes == 8))
            {
                return "Leo-> Se te presentarán ciertas oportunidades que no se repetirán. Deberás tomar una determinación bajo una gran presión.Existen barreras que es conveniente no cruzar en lo que a la relación se refiere, pues no tienen vuelta atrás. Manéjate con más cuidado.";
            }
            if ((fecha >= 24 && mes == 8) || (fecha <= 22 && mes == 9))
            {
                return "Virgo-> Los efectos de mantener tus obligaciones cumplidas están comenzando a hacerse sentir más cada día. Cuida más tu cuerpo.El paso del tiempo es un erosionador natural para la pareja, pero esto no representa un problema insalvable para nada. El amor devoto es la clave.";
            }
            if ((fecha >= 23 && mes == 9) || (fecha <= 22 && mes == 10))
            {
                return "Libra-> Hoy no pretendas que los demás sigan el tren de tus caprichos. Hacen lo que pueden y cómo pueden, compréndelos un poco más.Tu ansiedad te está matando, contrólala o echarás todo a perder. Haz ejercicios de relajación y armoniza tu hogar con velas.";
            }
            if ((fecha >= 23 && mes == 10) || (fecha <= 22 && mes == 11))
            {
                return "Escorpio-> Si no quieres pelearte con tu familia, lo mejor es que calles ciertos comentarios. A veces conviene optar por el silencio.Cambiar los muebles de lugar servirá para que las energías de tu hogar se renueven y se alejen las ondas negativas. Comienza hoy mismo.";
            }
            if ((fecha >= 23 && mes == 11) || (fecha <= 21 && mes == 12))
            {
                return "Sagitario-> Trata de que nadie te saque de quicio. Hoy no tienes ganas de escuchar reclamos ni problemas. Haz oídos sordos.Tienes trabajo, salud y un pasar económico que te permite vivir tranquilo. Piensa en ayudar a quienes lo necesiten.";
            }
            if ((fecha >= 22 && mes == 12) || (fecha <= 20 && mes == 01))
            {
                return "Capricornio-> Trata de que las noticias que lleguen hasta ti no logren afectar tu ánimo. El día será denso y te conviene estar de buen humorUna alimentación sana y balanceada te ayudará a bajar esos kilitos de más. No son muchos, pero necesitas voluntad para lograrlo..";
            }
            if ((fecha >= 21 && mes == 01) || (fecha <= 19 && mes == 02))
            {
                return "Acuario-> Hoy puede ser un día especial, todo depende de cómo lo enfrentes. Estate relajado y con la mente abierta a nuevas ideas.Sé creativo y dale rienda suelta a tu imaginación. Sólo dejando de lado ideas preconcebidas lograrás avanzar en tus proyectos.";
            }
            if ((fecha >= 20 && mes == 02) || (fecha <= 20 && mes == 03))
            {
                return "Piscis-> Hoy puede ser un día especial, todo depende de cómo lo enfrentes. Estate relajado y con la mente abierta a nuevas ideas.Sé creativo y dale rienda suelta a tu imaginación. Sólo dejando de lado ideas preconcebidas lograrás avanzar en tus proyectos.";
            }
            return "";
        }
        [HttpPost]
        public string HoroscopoPost([FromHeader]int fecha, [FromHeader] int mes)
        {
            if (fecha > 31 || fecha < 1)
            {
                return "Error.Ingresar una fecha con valor establecido";
            }
            if (mes > 12 || mes < 1)
            {
                return "Error.Ingresar el mes con valor establecido";
            }
            if ((fecha >= 21 && mes == 3) || (fecha <= 20 && mes == 4))
            {
                return "Aries-> No busques pretextos poco creíbles para justificar tus errores. Sé más responsable y hazte cargoLas diferencias de criterio son muy notables.No coinciden en nada, así que por su bien lo mejor es que la relación finalice. de tus desaciertos";
            }
            if ((fecha >= 21 && mes == 4) || (fecha <= 20 && mes == 5))
            {
                return "Tauro->Si buscas un consejo, recurre a tu familia. Tus amigos no son del todo objetivos, pero tu familia tiene una visión más amplia.Aparecerán nuevas amistades. Un cambio de ámbito te pondrá en contacto con personas de otra generación, que formarán parte de tu vida.";
            }
            if ((fecha >= 21 && mes == 5) || (fecha <= 21 && mes == 6))
            {
                return "Geminis-> Sucederá algo que te hará pensar que quienes dicen ser tus amigos no son tan sinceros como parecen. Analízalos mejor.Lograrás las cosas a tu manera, de la forma que te las habías propuestos. Tu intransigencia es imbatible, sigue por ese camino.";
            }
            if ((fecha >= 22 && mes == 6) || (fecha <= 22 && mes == 7))
            {
                return "Cancer-> Hoy sientes que nada te conforma y te molesta el estar rodeado de gente. Relájate y regálate un tiempo para ti cuando llegues a tu casa.Trata de mantener una alimentación equilibrada si no quieres terminar haciendo dieta. Beber mucha agua le hará bien a tu piel.";
            }
            if ((fecha >= 23 && mes == 7) || (fecha <= 23 && mes == 8))
            {
                return "Leo-> Se te presentarán ciertas oportunidades que no se repetirán. Deberás tomar una determinación bajo una gran presión.Existen barreras que es conveniente no cruzar en lo que a la relación se refiere, pues no tienen vuelta atrás. Manéjate con más cuidado.";
            }
            if ((fecha >= 24 && mes == 8) || (fecha <= 22 && mes == 9))
            {
                return "Virgo-> Los efectos de mantener tus obligaciones cumplidas están comenzando a hacerse sentir más cada día. Cuida más tu cuerpo.El paso del tiempo es un erosionador natural para la pareja, pero esto no representa un problema insalvable para nada. El amor devoto es la clave.";
            }
            if ((fecha >= 23 && mes == 9) || (fecha <= 22 && mes == 10))
            {
                return "Libra-> Hoy no pretendas que los demás sigan el tren de tus caprichos. Hacen lo que pueden y cómo pueden, compréndelos un poco más.Tu ansiedad te está matando, contrólala o echarás todo a perder. Haz ejercicios de relajación y armoniza tu hogar con velas.";
            }
            if ((fecha >= 23 && mes == 10) || (fecha <= 22 && mes == 11))
            {
                return "Escorpio-> Si no quieres pelearte con tu familia, lo mejor es que calles ciertos comentarios. A veces conviene optar por el silencio.Cambiar los muebles de lugar servirá para que las energías de tu hogar se renueven y se alejen las ondas negativas. Comienza hoy mismo.";
            }
            if ((fecha >= 23 && mes == 11) || (fecha <= 21 && mes == 12))
            {
                return "Sagitario-> Trata de que nadie te saque de quicio. Hoy no tienes ganas de escuchar reclamos ni problemas. Haz oídos sordos.Tienes trabajo, salud y un pasar económico que te permite vivir tranquilo. Piensa en ayudar a quienes lo necesiten.";
            }
            if ((fecha >= 22 && mes == 12) || (fecha <= 20 && mes == 01))
            {
                return "Capricornio-> Trata de que las noticias que lleguen hasta ti no logren afectar tu ánimo. El día será denso y te conviene estar de buen humorUna alimentación sana y balanceada te ayudará a bajar esos kilitos de más. No son muchos, pero necesitas voluntad para lograrlo..";
            }
            if ((fecha >= 21 && mes == 01) || (fecha <= 19 && mes == 02))
            {
                return "Acuario-> Hoy puede ser un día especial, todo depende de cómo lo enfrentes. Estate relajado y con la mente abierta a nuevas ideas.Sé creativo y dale rienda suelta a tu imaginación. Sólo dejando de lado ideas preconcebidas lograrás avanzar en tus proyectos.";
            }
            if ((fecha >= 20 && mes == 02) || (fecha <= 20 && mes == 03))
            {
                return "Piscis-> Hoy puede ser un día especial, todo depende de cómo lo enfrentes. Estate relajado y con la mente abierta a nuevas ideas.Sé creativo y dale rienda suelta a tu imaginación. Sólo dejando de lado ideas preconcebidas lograrás avanzar en tus proyectos.";
            }

            return "";
        }
    }
}
