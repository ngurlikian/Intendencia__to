using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Persistencia
{
    public class Repository
    {
        private CuadrillaRepository _CuadrillaRepository;
        private HistorialRepository _HistorialRepository;
        private ReclamoRepository _ReclamoRepository;
        private TipoReclamoRepository _TipoReclamoRepository;
        private UbicacionZonaRepository _UbicacionZonaRepository;
        private ZonaRepository _ZonaRepository;
        private UsuarioRepository _UsuarioRepository;
        public Repository()
        {
            this._CuadrillaRepository = new CuadrillaRepository();
            this._HistorialRepository = new HistorialRepository();
            this._ReclamoRepository = new ReclamoRepository();
            this._TipoReclamoRepository = new TipoReclamoRepository();
            this._UbicacionZonaRepository = new UbicacionZonaRepository();
            this._ZonaRepository = new ZonaRepository();
            this._UsuarioRepository = new UsuarioRepository();
        }

        public CuadrillaRepository getCuadrillaRepository()
        {
            return this._CuadrillaRepository;
        }

        public HistorialRepository getHistorialRepository()
        {
            return this._HistorialRepository;
        }

        public ReclamoRepository getReclamoRepository()
        {
            return this._ReclamoRepository;
        }

        public TipoReclamoRepository getTipoReclamoRepository()
        {
            return this._TipoReclamoRepository;
        }
        public UbicacionZonaRepository getUbicacionZonaRepository()
        {
            return this._UbicacionZonaRepository;
        }
        public ZonaRepository getZonaRepository()
        {
            return this._ZonaRepository;
        }
        public UsuarioRepository getUsuarioRepository()
        {
            return this._UsuarioRepository;
        }
    }
}
