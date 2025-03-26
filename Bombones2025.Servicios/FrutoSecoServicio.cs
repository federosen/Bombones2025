using Bombones2025.Datos.Repositorios;
using Bombones2025.Entidades;

namespace Bombones2025.Servicios
{
    public class FrutoSecoServicio
    {
        private readonly FrutoSecoRepositorio _frutoSecoRepositorio = null!;
        public FrutoSecoServicio(string ruta)
        {
            _frutoSecoRepositorio = new FrutoSecoRepositorio(ruta);
        }


        public List<FrutoSeco> GetFrutoSeco()
        {
            return _frutoSecoRepositorio.GetFrutoSecos();
        }
    }
}
