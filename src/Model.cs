using System.IO;
using System.IO.Compression;
using Femyou.Internal;

namespace Femyou
{
  public class Model
  {
    public static IModel Load(string fmuPath)
    {
      var TmpFolder = Path.Combine(Path.GetTempPath(), nameof(Femyou), Path.GetFileName(fmuPath));
      ZipFile.ExtractToDirectory(fmuPath, TmpFolder, true);
      return new ModelImpl(TmpFolder);
    }
    public static IModel Load(Stream fmuStream, string fmuPath)
    {
      var TmpFolder = Path.Combine(Path.GetTempPath(), nameof(Femyou), Path.GetFileName(fmuPath));
      ZipFile.ExtractToDirectory(fmuStream, TmpFolder, true);
      return new ModelImpl(TmpFolder);
    }
  }
}
