//This code was generated by a tool.
//Changes to this file will be lost if the code is regenerated.
// See the blog post here for help on using the generated code: http://erikej.blogspot.dk/2014/10/database-first-with-sqlite-in-universal.html
using SQLite;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

//https://medium.com/@reyes.leomaris/trabajando-con-bases-de-datos-locales-en-xamarin-forms-c34a0a16ac26

namespace Tabs
{
    public class SQLiteDb
    {
        string _path;
        SQLiteAsyncConnection databaseAFE;

        public SQLiteDb(string path)
        {
            _path = path;
            Create();
        }
        
         public void Create()
        {
            databaseAFE = new SQLiteAsyncConnection(_path);
            databaseAFE.CreateTableAsync<AFE>().Wait();
            databaseAFE.CreateTableAsync<AFE_POZO>().Wait();
            databaseAFE.CreateTableAsync<DECLINACION>().Wait();
            databaseAFE.CreateTableAsync<MODELO>().Wait();
            databaseAFE.CreateTableAsync<POZO>().Wait();
            databaseAFE.CreateTableAsync<PRODUCCION>().Wait();
            databaseAFE.CreateTableAsync<PROYECTO>().Wait();
        }

        //ver tablas en lista
        public Task<List<AFE>> GetAFEAsync()
        {
            return databaseAFE.Table<AFE>().ToListAsync();
        }
        public Task<List<AFE_POZO>> GetAFE_POZOAsync()
        {
            return databaseAFE.Table<AFE_POZO>().ToListAsync();
        }
        public Task<List<DECLINACION>> GetDECLINACIONAsync()
        {
            return databaseAFE.Table<DECLINACION>().ToListAsync();
        }
        public Task<List<MODELO>> GetMODELOAsync()
        {
            return databaseAFE.Table<MODELO>().ToListAsync();
        }
        public Task<List<POZO>> GetPOZOAsync()
        {
            return databaseAFE.Table<POZO>().ToListAsync();
        }
        public Task<List<PRODUCCION>> GetPRODUCCIONAsync()
        {
            return databaseAFE.Table<PRODUCCION>().ToListAsync();
        }
        public Task<List<PROYECTO>> GetPROYECTOAsync()
        {
            return databaseAFE.Table<PROYECTO>().ToListAsync();
        }


        //insertar datos en las tablas
        public Task<int> InsAFEAsync(AFE afe)
        {
            return databaseAFE.InsertAsync(afe);
        }
        public Task<int> InsAFE_POZOAsync(AFE_POZO afe_pozo)
        {
            return databaseAFE.InsertAsync(afe_pozo);
        }
        public Task<int> InsDECLINACIONsync(DECLINACION declinacion)
        {
            return databaseAFE.InsertAsync(declinacion);
        }
        public Task<int> InsMODELOAsync(MODELO modelo)
        {
            return databaseAFE.InsertAsync(modelo);
        }
        public Task<int> InsPOZOAsync(POZO pozo)
        {
            return databaseAFE.InsertAsync(pozo);
        }
        public Task<int> InsPRODUCCIONAsync(PRODUCCION produccion)
        {
            return databaseAFE.InsertAsync(produccion);
        }
        public Task<int> InsPROYECTOAsync(PROYECTO proyect)
        {
            return databaseAFE.InsertAsync(proyect);
        }

        //Actualizar datos
        public Task<int> UpdateAFEAsync(AFE afe)
        {
            return databaseAFE.UpdateAsync(afe);
        }
        public Task<int> UpdateAFE_POZOAsync(AFE_POZO afe_pozo)
        {
            return databaseAFE.UpdateAsync(afe_pozo);
        }
        public Task<int> UpdateDECLINACIONAsync(DECLINACION declinacion)
        {
            return databaseAFE.UpdateAsync(declinacion);
        }
        public Task<int> UpdateMODELOAsync(MODELO modelo)
        {
            return databaseAFE.UpdateAsync(modelo);
        }
        public Task<int> UpdatePOZOAsync(POZO pozo)
        {
            return databaseAFE.UpdateAsync(pozo);
        }
        public Task<int> UpdatePRODUCCIONAsync(PRODUCCION produccion)
        {
            return databaseAFE.UpdateAsync(produccion);
        }
        public Task<int> UpdatePROYECTOAsync(PROYECTO proyecto)
        {
            return databaseAFE.UpdateAsync(proyecto);
        }

        //eliminar datos de tablas
        public Task<int> DeleteAFEAsync(AFE afe)
        {
            return databaseAFE.DeleteAsync(afe);
        }
        public Task<int> DeleteAFE_POZOAsync(AFE_POZO afe_pozo)
        {
            return databaseAFE.DeleteAsync(afe_pozo);
        }
        public Task<int> DeletDECLINACIONAsync(DECLINACION declinacion)
        {
            return databaseAFE.DeleteAsync(declinacion);
        }
        public Task<int> DeleteMODELOAsync(MODELO modelo)
        {
            return databaseAFE.DeleteAsync(modelo);
        }
        public Task<int> DeletePOZOAsync(POZO pozo)
        {
            return databaseAFE.DeleteAsync(pozo);
        }
        public Task<int> DeletePRODUCCIONAsync(PRODUCCION produccion)
        {
            return databaseAFE.DeleteAsync(produccion);
        }
        public Task<int> DeletePROYECTOAsync(PROYECTO proyecto)
        {
            return databaseAFE.DeleteAsync(proyecto);
        }

    }
    public partial class AFE
    {
        [PrimaryKey, AutoIncrement]
        public Int64 Id { get; set; }
        
        [NotNull]
        public Int32 ProyectoId { get; set; }
        
        [MaxLength(30)]
        [NotNull]
        public String Nombre { get; set; }
        
        [MaxLength(50)]
        [NotNull]
        public String Descripcion { get; set; }
        
        public Decimal? Qi { get; set; }
        
        public Decimal? Di { get; set; }
        
        public Decimal? B { get; set; }
        
        [MaxLength(50)]
        public String Pozos { get; set; }
        
        [MaxLength(10)]
        public String Operacion { get; set; }
        
        [MaxLength(10)]
        public String Hidrocarburo { get; set; }
        
        public Int32? ModeloId { get; set; }
        
    }
    
    public partial class AFE_POZO
    {
        [NotNull]
        public Int32 AFEId { get; set; }
        
        [NotNull]
        public Int32 PozoId { get; set; }
        
    }
    
    public partial class DECLINACION
    {
        [NotNull]
        public Int32 AFEId { get; set; }
        
        [NotNull]
        public Int32 Tiempo { get; set; }
        
        public Decimal? Prod { get; set; }
        
        public Decimal? ARPS { get; set; }
        
        public Decimal? ProdAcum { get; set; }
        
        public Decimal? ARPSAcum { get; set; }
        
    }
    
    public partial class MODELO
    {
        [PrimaryKey, AutoIncrement]
        public Int64 Id { get; set; }
        
        [MaxLength(30)]
        [NotNull]
        public String Nombre { get; set; }
        
    }
    
    public partial class POZO
    {
        [PrimaryKey, AutoIncrement]
        public Int64 Id { get; set; }
        
        [MaxLength(30)]
        [NotNull]
        public String Nombre { get; set; }
        
    }
    
    public partial class PRODUCCION
    {
        [PrimaryKey, AutoIncrement]
        public Int64 Id { get; set; }
        
        [NotNull]
        public Int32 PozoId { get; set; }
        
        [NotNull]
        public Int32 Anio { get; set; }
        
        [NotNull]
        public Int32 Mes { get; set; }
        
        [NotNull]
        public Int32 Tiempo { get; set; }
        
        [NotNull]
        public Int32 Aceite { get; set; }
        
        [NotNull]
        public Decimal Gas { get; set; }
        
    }
    
    public partial class PROYECTO
    {
        [PrimaryKey, AutoIncrement]
        public Int64 Id { get; set; }
        
        [MaxLength(30)]
        [NotNull]
        public String Nombre { get; set; }
        
        [MaxLength(50)]
        public String Descripcion { get; set; }
        
    }
}
