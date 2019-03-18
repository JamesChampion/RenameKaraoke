using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenameKarakoke.Objects
{
    class RenameHelper
    {
        private DataSet _dataSet { get; set; }
        private FileCompressionHelper _fileCompressionHelper { get; set; }
        private SongListManager _songListManager { get; set; }
        private string _savePath { get; set; }
        private string _sourcePath { get; set; }
        public RenameHelper(DataSet dataset)
        {
            _dataSet = dataset;
            _songListManager = _dataSet.SongListManager;
            _fileCompressionHelper = new FileCompressionHelper();
            _sourcePath = _dataSet.SongSourceDirPath;
        }

        public void EvaluateUserInput(bool isCompressed)
        {
            var directoryWriter = new DirectoryWriter();
            var _savePath = directoryWriter.GetDirectorySavePath();
            if (isCompressed)
            {
                
                RenameSelectedSongs(_fileCompressionHelper);
                //Used FileCompressionHelper to Rename Songs
            }
            else
            {
                //Use FileWriter To Rename Songs
            }
            //Finally Copy All Songs That Did Not Get Renamed


        }





        private Song FindCorrectSongInfo(Song querySong)
        {
            return _songListManager.MasterSongList.FirstOrDefault(s => s.Title == querySong.Title);

        }

        private void RenameSelectedSongs(object helperClass)
        {
            var selectedSongList = _songListManager.SelectedSongList;
            var directorySavePath = Path.GetDirectoryName(_savePath);
            if(helperClass.GetType() == typeof(FileCompressionHelper))
            {
                
                foreach(Song song in selectedSongList)
                {
                    var correctSongInfo = FindCorrectSongInfo(song);
                    if (correctSongInfo != null)
                    {

                    }

                }
                
            



            }
        }

      



    }
}
