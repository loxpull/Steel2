using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;

class Reader
{
    public double[] ReadText(string path)
    {
        //Переменная хранящая все себе текст из файла
        string temp = File.ReadAllText(path);

        List<double> res = new List<double>();


        foreach (Match match in Regex.Matches(temp, @"-?\d+([.,]\d+)?"))/*-? - отрицательное число, d+ - одну или более цифр,
                                                                        d+([.,] - числа с плавающей точкой или запятой*/
        {
            string number = match.Value.Replace(",", ".");
            res.Add(double.Parse(number, CultureInfo.InvariantCulture)); //CultureInfo.InvariantCulture - для корректного распознания числа
        }

        return res.ToArray();
    }
}
