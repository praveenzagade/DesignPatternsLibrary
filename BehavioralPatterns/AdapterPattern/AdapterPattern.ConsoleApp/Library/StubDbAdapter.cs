using System;
using System.Data;

namespace AdapterPattern.ConsoleApp.Library
{
    public class StubDbAdapter : IDbDataAdapter
    {
        #region Not Implemented
        public IDbCommand DeleteCommand
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public IDbCommand InsertCommand
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public MissingMappingAction MissingMappingAction
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public MissingSchemaAction MissingSchemaAction
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public IDbCommand SelectCommand
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public ITableMappingCollection TableMappings
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IDbCommand UpdateCommand
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public DataTable[] FillSchema(DataSet dataSet, SchemaType schemaType)
        {
            throw new NotImplementedException();
        }

        public IDataParameter[] GetFillParameters()
        {
            throw new NotImplementedException();
        }

        public int Update(DataSet dataSet)
        {
            throw new NotImplementedException();
        } 
        #endregion

        public int Fill(DataSet dataSet)
        {
            var myDataTable = new DataTable();
            myDataTable.Columns.AddRange(new DataColumn[]{
                new DataColumn("Id", typeof(int)),
                new DataColumn("Name", typeof(string)),
                new DataColumn("Description", typeof(string))});
            var myRow = myDataTable.NewRow();
            myRow[0] = 1;
            myRow[1] = "Adapter";
            myRow[2] = "Adapter description";
            myDataTable.Rows.Add(myRow);
            dataSet.Tables.Add(myDataTable);
            dataSet.AcceptChanges();
            return 1;
        }
    }
}
