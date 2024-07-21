using SchoolLibrary.DataProcessing;
using SchoolLibrary.Enums;
using SchoolLibrary.Models;

/// <summary>
/// Console application for processing and managing school data.
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        var processor = new DataProcessor();
        List<School> data = null;

        while (true)
        {
            Console.WriteLine("1. Открыть файл");
            Console.WriteLine("2. Просмотреть записи");
            Console.WriteLine("3. Сортировать данные");
            Console.WriteLine("4. Фильтровать данные");
            Console.WriteLine("5. Просмотреть N записей");
            Console.WriteLine("6. Сохранить данные");
            Console.WriteLine("7. Выход");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // Load data from a CSV file.
                    Console.WriteLine("Введите путь к файлу:");
                    var path = Console.ReadLine();
                    try
                    {
                        data = processor.LoadDataFromCsv(path);
                        Console.WriteLine("Данные успешно загружены.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка при загрузке данных: {ex.Message}");
                    }
                    break;
                
                case "2":
                    // Display records if data is loaded.
                    if (data != null)
                    {
                        foreach (var item in data)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Данные не загружены.");
                    }
                    break;
                
                case "3":
                    // Sort data if loaded.
                    if (data != null)
                    {
                        Console.WriteLine("Выберите поле для сортировки:");

                        Console.WriteLine("Сортировать по возрастанию? (y/n)");
                        var ascending = Console.ReadLine().ToLower() == "y";

                        try
                        {
                            data = processor.SortData(data, "okrug", ascending);
                            Console.WriteLine("Данные успешно отсортированы.");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Ошибка при сортировке данных: {ex.Message}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Данные не загружены.");
                    }
                    break;
                
                case "4":
                    // Filter data if loaded.
                    if (data != null)
                    {
                        Console.WriteLine("Выберите поле для фильтрации (1 - form_of_incorporation, 2 - submission):");
                        choice = Console.ReadLine();

                        if (choice == "1" || choice == "2")
                        {
                            Console.WriteLine("Введите ключевое слово для фильтрации:");
                            var keyword = Console.ReadLine();

                            var field = (choice == "1") ? "form_of_incorporation" : "submission";

                            try
                            {
                                var filteredData = processor.FilterData(data, field, keyword);
                                data = filteredData; // Сохраняем отфильтрованные данные
                                if (filteredData.Count > 0) // Изменено здесь
                                {
                                    Console.WriteLine("Найдены следующие записи:");
                                    foreach (var item in filteredData)
                                    {
                                        Console.WriteLine(item);
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Не найдено записей, соответствующих вашему запросу.");
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Ошибка при фильтрации данных: {ex.Message}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Выбран неверный вариант. Пожалуйста, выберите 1 или 2 для поля.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Данные не загружены.");
                    }
                    break;

                case "5":
                    // Display N records if loaded.
                    if (data != null)
                    {
                        Console.WriteLine("Введите количество записей для просмотра:");
                        var N = int.Parse(Console.ReadLine());

                        Console.WriteLine("Выберите позицию записей (1 - верх, 2 - низ):");
                        var position = Console.ReadLine() == "1" ? RecordPosition.Top : RecordPosition.Bottom;

                        try
                        {
                            var records = processor.GetRecords(data, N, position);
                            foreach (var record in records)
                            {
                                Console.WriteLine(record);
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Ошибка при получении записей: {ex.Message}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Данные не загружены.");
                    }
                    break;
                
                case "6":
                    // Save data if loaded.
                    if (data != null)
                    {
                        Console.WriteLine("Введите путь для сохранения файла:");
                        var savePath = Console.ReadLine();

                        Console.WriteLine("Выберите режим сохранения (1 - создать новый, 2 - заменить, 3 - добавить):");
                        var mode = (SaveMode)(int.Parse(Console.ReadLine()) - 1);

                        try
                        {
                            processor.SaveDataToCsv(data, savePath, mode);
                            Console.WriteLine("Данные успешно сохранены.");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Ошибка при сохранении данных: {ex.Message}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Данные не загружены.");
                    }
                    break;
                
                case "7":
                    // Exit the application.
                    return;
                
                default:
                    Console.WriteLine("Неизвестная опция.");
                    break;
            }
        }
    }
}
