namespace RenameKarakoke
{
  public interface IReader
    {
     

        void Read(string FileName);

        Song ParseSong(string line);


        string GetFilePath();

    }
}
