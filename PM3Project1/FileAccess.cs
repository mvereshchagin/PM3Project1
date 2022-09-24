namespace PM3Project1;

public enum MyFileAccess
{
    None = 0, // 0
    Read = 1, // 2^0 = 0001
    Write = 2, // 2^1 = 0010
    Execute = 4, // 2^2 = 0100
    ExecuteWithSudo = 8, // 2^3 = 1000
}