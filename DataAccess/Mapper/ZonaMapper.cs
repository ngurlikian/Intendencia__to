using CommonSolution.DTO;
using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapper
{
    public class ZonaMapper
    {
        public Zona mapDtoZonaToEntity(dtoZona dto)
        {
            Zona entity = new Zona();
            entity.NroDeZona = dto.NroDeZona;
            entity.Nombre = dto.Nombre;
            entity.Color = dto.Color;
            entity.Estado = dto.Estado;
            entity.Cuadrilla = this.mapDtoListCuadrillaToEntity(dto.colDtoCuadrilla);
            entity.Reclamo = this.mapDtoListReclamoToEntity(dto.colDtoReclamo);
            entity.UbicacionZona = this.mapDtoListUbicacionZonaToEntity(dto.colDtoUbicacionZona);
            return entity;
        }

        public List<Reclamo> mapDtoListReclamoToEntity(List<dtoReclamo> coldtos)
        {
            List<Reclamo> colreclamos = new List<Reclamo>();
            foreach (dtoReclamo item in coldtos)
            {
                Reclamo reclamo = this.mapDtoReclamoToEntity(item);
                colreclamos.Add(reclamo);
            }
            return colreclamos;
        }

        public Reclamo mapDtoReclamoToEntity(dtoReclamo dto)
        {
            Reclamo entity = new Reclamo();
            entity.NroDeReclamo = dto.NroDeReclamo;
            entity.NombreDeUsuario = dto.NombreDeUsuario;
            entity.NroDeZona = dto.NroDeZona;
            entity.NroDeTipoDeReclamo = dto.NroDeTipoDeReclamo;
            entity.Observacion = dto.Observacion;
            entity.Longitud = dto.Longitud;
            entity.Latitud = dto.Latitud;
            entity.FechaDeIngreso = dto.FechaDeIngreso;
            entity.EstadoDelReclamo = dto.EstadoDelReclamo;
            return entity;
        }

        public List<Cuadrilla> mapDtoListCuadrillaToEntity(List<dtoCuadrilla> coldtos)
        {
            List<Cuadrilla> colcuadrillas = new List<Cuadrilla>();
            foreach (dtoCuadrilla item in coldtos)
            {
                Cuadrilla cuadrilla = this.mapDtoCuadrillaToEntity(item);
                colcuadrillas.Add(cuadrilla);
            }
            return colcuadrillas;
        }

        public Cuadrilla mapDtoCuadrillaToEntity(dtoCuadrilla dto)
        {
            Cuadrilla entity = new Cuadrilla();
            entity.NroDeCuadrilla = dto.NroDeCuadrilla;
            entity.NroDeZona = dto.NroDeZona;
            entity.Encargado = dto.Encargado;
            entity.CantidadDePeones = dto.CantidadDePeones;
            entity.Nombre = dto.Nombre;
            return entity;
        }

        public List<UbicacionZona> mapDtoListUbicacionZonaToEntity(List<dtoUbicacionZona> coldtos)
        {
            List<UbicacionZona> colubicacionzonas = new List<UbicacionZona>();
            foreach (dtoUbicacionZona item in coldtos)
            {
                UbicacionZona ubicacionzonas = this.mapDtoUbicacionZonaToEntity(item);
                colubicacionzonas.Add(ubicacionzonas);
            }
            return colubicacionzonas;
        }

        public UbicacionZona mapDtoUbicacionZonaToEntity(dtoUbicacionZona dto)
        {
            UbicacionZona entity = new UbicacionZona();
            entity.NroUbicacionZona = dto.NroUbicacionZona;
            entity.NroDeZona = dto.NroDeZona;
            entity.Latitud = dto.Latitud;
            entity.Longitud = dto.Longitud;
            return entity;
        }
    }
}
