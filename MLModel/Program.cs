using MLModel;

string entryPromp;

Console.WriteLine("type a phrase in english: ");
entryPromp = Console.ReadLine();

if (entryPromp == "")
{
    Console.WriteLine("pls, type a phrase: ");
    entryPromp = Console.ReadLine();
    return;
}

var sampleData = new SentimentModel.ModelInput()
{
    Col0 = entryPromp!,
};

var result = SentimentModel.Predict(sampleData);

//var sentiment = result.PredictedLabel == 1 ? "Positive" : "Negative";

string sentiment;

if (result.PredictedLabel == 1)
{
    sentiment = "Positive";
    Console.WriteLine("Text: " + sampleData.Col0 + ", sentiment: " + sentiment);
}

else
{
    sentiment = "Negative";
    Console.WriteLine("Text: " + sampleData.Col0 + ", sentiment: " + sentiment);
}



