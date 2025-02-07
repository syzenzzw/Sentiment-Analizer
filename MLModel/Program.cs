using MLModel;

var sampleData = new SentimentModel.ModelInput()
{
    Col0 = @"Crust is not good.",
};

var result = SentimentModel.Predict(sampleData);

var sentiment = result.PredictedLabel == 1 ? "Positive" : "Negative";

Console.WriteLine("Text: " + sampleData.Col0 + ", sentiment: " + sentiment);