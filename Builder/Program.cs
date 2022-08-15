//https://online.visual-paradigm.com/w/pplxtipa/diagrams/#diagram:workspace=pplxtipa&proj=0&id=11
using Builder;

ApplicationBuilder builder = new ApplicationBuilder();

Director director = new Director(builder);


director.BuildFullFeature();

builder.GetProduct().Show();

Console.WriteLine("=======");

director.BuildNoneLocalDatabase();


builder.GetProduct().Show();