using Composite;
using Microsoft.Extensions.DependencyInjection;

/*
 * Создайте дерево объектов, позволяющее инкрементировать и
 * декрементировать значение целого поля по всем нижележащим элементам дерева
 */

var services = new ServiceCollection();
services.AddTransient<ITreeBuilder, TreeBuilder>();

using var serviceProvider = services.BuildServiceProvider();
var treeBuilder = serviceProvider.GetRequiredService<ITreeBuilder>();

var tree = treeBuilder.GetDefaultTree();

tree.Increment();
Console.WriteLine("---------------------------");
tree.Increment();
Console.WriteLine("---------------------------");
tree.Decrement();