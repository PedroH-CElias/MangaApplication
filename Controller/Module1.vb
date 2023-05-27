Module Module1

    Private server = "DESKTOP-CSTV6N9"
    Private dataBase = "MangaTec"
    Private user = ""
    Private password = ""

    Public ReadOnly strCon = $"Data Source={server}; Integrated Security=true;Initial Catalog={dataBase};user ID={user};Password={password}"


    Public email As String
End Module
