using Composite;
using Microsoft.Extensions.DependencyInjection;

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