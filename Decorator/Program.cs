// See https://aka.ms/new-console-template for more information
using Decorator;
// แจงนับ
// แผนที่
//

var myBase = new ListingOperation();

var decorator1 = new PlottingMapDecorator(myBase);

var decorator2 = new TrainingDecorator(decorator1);

var client = new Client();

client.Working(decorator2);