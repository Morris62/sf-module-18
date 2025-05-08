using Builder;

IBuilder builder = new ProductBuilder();

var buildManager = new BuildManager(builder);

buildManager.StartBuildingProcess();
Product product = builder.GetBuilderResult();

Console.ReadKey();