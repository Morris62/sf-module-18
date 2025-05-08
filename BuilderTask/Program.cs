using BuilderTask;

var carPlant = new CarPlant();

Conveyor builder = new CarConveyor();
carPlant.Construct(builder);
builder.Product.Show();

builder = new MotoConveyor();
carPlant.Construct(builder);
builder.Product.Show();

builder = new ScooterConveyor();
carPlant.Construct(builder);
builder.Product.Show();
