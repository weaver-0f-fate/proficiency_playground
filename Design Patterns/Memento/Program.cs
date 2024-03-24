using Memento;
using Microsoft.Extensions.DependencyInjection;

/*
 * Написать программу, используя паттерн Memento

❑Текстовый редактор
Есть функции:
Сохранять новую версию документа
Возвращать определенную версию документа
 */

var serviceProvider = new ServiceCollection()
    .AddTransient<IDocument, Document>()
    .AddTransient<ICaretaker, Caretaker>()
    .BuildServiceProvider();

var document = serviceProvider.GetRequiredService<IDocument>();
var caretaker = serviceProvider.GetRequiredService<ICaretaker>();

caretaker.SaveMemento(document);
document.SetCotent("This is new document content");
caretaker.SaveMemento(document);

document.PrintInfo();
document.RestoreMemento(caretaker.RetrieveDocumentVersion(1));
document.PrintInfo();
document.RestoreMemento(caretaker.RetrieveDocumentVersion(2));
document.PrintInfo();