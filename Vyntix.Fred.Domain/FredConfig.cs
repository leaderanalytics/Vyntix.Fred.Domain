namespace LeaderAnalytics.Vyntix.Fred.Domain;

public class FredConfig : IDataProviderConfig
{
    private int _ID;
    private string _Name;
    private int _SystemID;
    private string _DownloadURI;
    private string _Login;
    private string _Password;
    private DateTime? _LastDownload;
    private DownloadResult _LastDownloadResult;
    private int _UserID;

    public FredConfig(IDataProvider dp)
    {
        _ID = dp.ID;
        _Name = dp.Name;
        _SystemID = dp.SystemID;
        _DownloadURI = dp.Setting1;
        _Login = dp.Setting2;
        _Password = null; 
        _LastDownload = dp.LastDownloadDate;
        _LastDownloadResult = dp.LastDownloadResult;
        _UserID = dp.UserID;
    }
    
    public int ID { get { return _ID; } }
    
    public string Name { get { return _Name; } }
    
    public int SystemID { get { return _SystemID; } }
    
    public string DownloadURI { get { return _DownloadURI; } }
    
    public string Login { get { return _Login; } }
    
    public string Password { get { return _Password; } }

    public DateTime? LastDownload { get { return _LastDownload; } }

    public DownloadResult LastDownloadResult { get { return _LastDownloadResult; } }

    public int UserID { get { return _UserID; } }
}
