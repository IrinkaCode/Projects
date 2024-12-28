
using DbFromCSV;
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
using System;
using (IrisContext db = new IrisContext())
{
    StreamReader reader = new StreamReader("iris.csv");
    CsvReader csvReader = new CsvReader(reader,
    new CsvConfiguration(CultureInfo.InvariantCulture)
    {
        Delimiter = ",",
        HasHeaderRecord = true,
        HeaderValidated = null
    });
    List<IrisLoad> records = csvReader.GetRecords<IrisLoad>().ToList();
    foreach (var record in records)
    {
        Iris iris = new Iris()
        {
            Veriety = record.Variety,
            SepalWight = record.SepalWidth,
            Petallenght = record.PetalLength,
            PetalWight = record.PetalWidth,
            Sepallenght = record.SepalLength
        };
        db.Iris.Add(iris);
    }
    db.SaveChanges();
    reader.Close();
}