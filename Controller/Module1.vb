Module Module1

    Private server = "DESKTOP-CSTV6N9" 'Alterar de acordo com o servidor local
    Private dataBase = "MangaTec" 'Alterar de acordo com o nome do banco de dados
    Private user = ""
    Private password = ""

    Public ReadOnly strCon = $"Data Source={server}; Integrated Security=true;Initial Catalog={dataBase};user ID={user};Password={password}"

End Module
