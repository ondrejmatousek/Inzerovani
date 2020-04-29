using Dapper;
using Inzerovani.DomainModel.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;

namespace DataAccessLayer
{
    public class InzeratDao : IInzeratDao
    {
        private readonly ConnectionStringSettings connectionStringSettings;

        public InzeratDao(ConnectionStringSettings connectionStringSettings)
        {
            this.connectionStringSettings = connectionStringSettings;
        }

        string queryGetAll = "SELECT Inzerat.[IdInzerat], Inzerat.[NazevInzeratu], Inzerat.[CisloInzeratu], Inzerat.[DatumVytvoreni], Inzerat.[KategorieId], Kategorie.[IdKategorie], Kategorie.[Nazev], Kategorie.[ParentId]" +
                            " FROM Inzerat" +
                            " INNER JOIN Kategorie" +
                            " ON Inzerat.[KategorieId] = Kategorie.[IdKategorie]";
        public List<Inzerat> GetAll()
        {
            List<Inzerat> result = new List<Inzerat>();
            using (DbConnection conn = new SqlConnection(connectionStringSettings.ConnectionString))
            {
                result = conn.Query<Inzerat>(queryGetAll).ToList();
            }
            return result;
        }

        public Inzerat GetById(int? IdInzerat)
        {
            Inzerat inzerat = new Inzerat();
            string query = "SELECT Inzerat.[IdInzerat], Inzerat.[NazevInzeratu], Inzerat.[CisloInzeratu], Inzerat.[DatumVytvoreni]" +
                           "FROM Inzerat " +
                           "WHERE Inzerat.IdInzerat = @IdInzerat";

            using (DbConnection conn = new SqlConnection(connectionStringSettings.ConnectionString))
            {
                inzerat = conn.Query<Inzerat>(query, new { @IdInzerat = IdInzerat }).FirstOrDefault();
            }
            return inzerat;
        }

        public void Insert(Inzerat insertee)
        {
            string query = "INSERT INTO Inzerat (IdInzerat, NazevInzeratu, CisloInzeratu, DatumVytvoreni)" +
                           "VALUES (@IdInzerat, @NazevInzeratu, @CisloInzeratu, @DatumVytvoreni)" +
                           "SELECT IdInzerat FROM Inzerat WHERE Inzerat.IdInzerat = Scope_Identity()";

            using (DbConnection conn = new SqlConnection(connectionStringSettings.ConnectionString))
            {
                insertee.DatumVytvoreni = DateTime.Now;
                Inzerat inzeratZDB = conn.Query<Inzerat>(query, new { insertee.NazevInzeratu, insertee.CisloInzeratu, insertee.DatumVytvoreni }).FirstOrDefault();
                insertee.IdInzerat = inzeratZDB.IdInzerat;
            }
        }

        public void Update(Inzerat insertee)
        {
            string query = "UPDATE Inzerat SET (IdInzerat=@IdInzerat, NazevInzeratu=@NazevInzeratu, CisloInzeratu=@CisloInzeratu, DatumVytvoreni=@DatumVytvoreni)" +
                           "WHERE Inzerat.IdInzerat = @IdInzerat";

            using (DbConnection conn = new SqlConnection(connectionStringSettings.ConnectionString))
            {

                Inzerat inzeratZDB = conn.Query<Inzerat>(query, new { insertee.NazevInzeratu, insertee.CisloInzeratu, insertee.DatumVytvoreni }).FirstOrDefault();
            }
        }

        public void Delete(Inzerat inzerat)
        {
            string query = "DELETE FROM Inzerat WHERE Inzerat.IdInzerat = @IdInzerat";
            using (DbConnection conn = new SqlConnection(connectionStringSettings.ConnectionString))
            {

                int PocetUpravenychRadku = conn.Execute(query, new { inzerat.IdInzerat });
            }
        }
    }
}
