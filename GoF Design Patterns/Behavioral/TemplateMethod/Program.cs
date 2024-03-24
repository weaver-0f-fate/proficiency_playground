using TemplateMethod;

var dateWriter = AbstractFileWriter.GetDateFileWriter();
var timeWriter = AbstractFileWriter.GetTimeFileWriter();

dateWriter.Write("output1.txt");
timeWriter.Write("output2.txt");