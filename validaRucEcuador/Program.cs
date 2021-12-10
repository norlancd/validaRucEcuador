using validaRucEcuador;


string ruc = "3050045719001";

bool valid = ValidateRUC.Validate(ruc);

if (valid)
{
    Console.WriteLine(string.Format("El RUC {0} es válido", ruc));
}
else
{
    Console.WriteLine(string.Format("El RUC {0} NO es válido", ruc));
}