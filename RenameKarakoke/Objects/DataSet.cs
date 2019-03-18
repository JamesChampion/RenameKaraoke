

using RenameKarakoke.Enum;
using System;
using System.Collections.Generic;
using System.Data;

namespace RenameKarakoke.Objects
{
    public class DataSet
    {
        public string SongSourceDirPath { get; set; }
        public SongListManager SongListManager { get; set; }

        public DataSet(SongListManager songListManager, string songDirPath)
        {
            SongListManager = songListManager;
            SongSourceDirPath = songDirPath;
        }

        public DataTable GetDataTable(InputSource dataSource)
        {
            var dataTable = new DataTable();
            InitalizeDataTable(dataTable, dataSource);
            PopulateDataTable(dataTable);
            return dataTable;
        }


        private void InitalizeDataTable(DataTable dataTable, InputSource dataSource)
        {
            
            SetTableName(dataTable, dataSource);
            if (IsMasterTable(dataTable))
            {
                InitalizeMasterTable(dataTable);
            }
            if (IsQueryTable(dataTable))
            {
                InitalizeQueryTable(dataTable);
            }

        }

        private void SetTableName(DataTable dt, InputSource dataSource)
        {
            string tableName = "";
            switch (dataSource)
            {
                case InputSource.textFile:
                    tableName = "Master Song Table";
                    break;

                case InputSource.directory:
                    tableName = "Query Song Table";
                    break;  

            }
            dt.TableName = tableName;
        }

        private bool IsMasterTable(DataTable dt) => dt.TableName == "Master Song Table";

        private bool IsQueryTable(DataTable dt) => dt.TableName == "Query Song Table";

        private void InitalizeQueryTable(DataTable dt)
        {
            var columnDataType = Type.GetType("System.String");
            dt.Columns.Add("CheckBox", typeof(bool));
            dt.Columns.Add("ID", columnDataType);
            dt.Columns.Add("Artist", columnDataType);
            dt.Columns.Add("Title", columnDataType);

        }

        private void InitalizeMasterTable(DataTable dt)
        {
            var columnDataType = Type.GetType("System.String");
            dt.Columns.Add("ID", columnDataType);
            dt.Columns.Add("Artist", columnDataType);
            dt.Columns.Add("Title", columnDataType);
  
        }

        private void PopulateDataTable(DataTable dt)
        {
            if (IsMasterTable(dt))
            {
                foreach(Song song in SongListManager.MasterSongList)
                {
                    dt.Rows.Add(new object[] { song.ID, song.Artist, song.Title });
                }
            }

            if (IsQueryTable(dt))
            {
                foreach (Song song in SongListManager.QuerySongList)
                {
                    dt.Rows.Add(new object[] { false, song.ID, song.Artist, song.Title });
                }
            }
        }

    }
}