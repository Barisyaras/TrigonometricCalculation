using Calculation;
Console.WriteLine("Hesaplama türü");
Console.WriteLine("1-Sin 2-Cos 3-Tan 4-Cotan");
int calculationType = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Gireceğiniz açı değerinin tipi nedir?");
Console.WriteLine("1- Derece  2- Radian");
int degreeType = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Değerlerini görmek istediğiniz açıyı giriniz");
int degree = Convert.ToInt32(Console.ReadLine());

TrigonometricCalculation calculation = new TrigonometricCalculation();

//if (degreeType == 1)
//{
//    double radian = calculation.CovertAngleToRadian(degree);

//    if (calculationType == 1)
//        Console.WriteLine(calculation.CalculateSinusByRadian(radian));

//    else if (calculationType == 2)
//        Console.WriteLine(calculation.CalculateCosinusByRadian(radian));

//    else if (calculationType == 3)
//        Console.WriteLine(calculation.CalculateTangentByRadian(radian));

//    else if (calculationType == 4)
//        Console.WriteLine(calculation.CalculateCotangentByRadian(radian));
//}
//else
//{
//    if (calculationType == 1)
//        Console.WriteLine(calculation.CalculateSinusByRadian(degree));

//    else if (calculationType == 2)
//        Console.WriteLine(calculation.CalculateCosinusByRadian(degree));

//    else if (calculationType == 3)
//        Console.WriteLine(calculation.CalculateTangentByRadian(degree));

//    else if (calculationType == 4)
//        Console.WriteLine(calculation.CalculateCotangentByRadian(degree));
//}


if (degreeType==1)
{
    double radian = calculation.CovertAngleToRadian(degree);
    switch (calculationType) 
    {
        case 1:
            calculation.WriteRoundedCalculation(calculation.CalculateSinusByRadian(radian));
            
            break;
        case 2:
            calculation.WriteRoundedCalculation(calculation.CalculateCosinusByRadian(radian));
            break;
        case 3:
            if (degree == 90 || degree== 270)
                Console.WriteLine("Tanımsız");
            else
                calculation.WriteRoundedCalculation(calculation.CalculateTangentByRadian(radian));
            break;
        case 4:
            if (degree == 0 || degree== 180 || degree== 360)
                Console.WriteLine("Tanımsız");
            else    
                calculation.WriteRoundedCalculation(calculation.CalculateCotangentByRadian(radian));
            break;
       
    }
}
else
{
    double angle = (degree / Math.PI) * 180;
    switch (calculationType)
    {
        case 1:
            calculation.WriteRoundedCalculation(calculation.CalculateSinusByRadian(degree));
            break;
        case 2:
            calculation.WriteRoundedCalculation(calculation.CalculateCosinusByRadian(degree));
            break;
        case 3:
            if (angle == 90 || angle == 270)
                Console.WriteLine("Tanımsız");
            else
                calculation.WriteRoundedCalculation(calculation.CalculateTangentByRadian(degree));
            break;
        case 4:
            if (degree == 0 || degree == 180 || degree == 360)
                Console.WriteLine("Tanımsız");
            else
                calculation.WriteRoundedCalculation(calculation.CalculateCotangentByRadian(degree));
            break;
    }
}