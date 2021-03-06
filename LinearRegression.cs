using System;

class LinearRegression
{
    Random random = new Random();

    float weight;
    float bias = 0f;
    float learningRate = 0.1f;


    public LinearRegression()
    {
        weight = (float) random.NextDouble();
    }

    public float guess(float input)
    {
        float sum = 0f;
        sum = (weight * input) + bias;
        return sum;
    }

    
    public void train(float input, float output)
    {
        float guessed = guess(input);
        float error = costFunction(guessed, output);
        weight += error * input * learningRate;
    }

    float costFunction(float guessed, float output)
    {
        float result = (guessed - output);
        float minimized = (float) ((1/2) * Math.Pow(result, 2));

        return minimized;
    }

}

class MainClass
{
  
  public static void Main (string[] args)
  {
    float[,] datas = new float[,] 
    {
        {32f, 37.9f},  
        {19.5f, 42.2f},  
        {13.3f, 47.3f},  
        {13.3f, 54.8f},  
        {5f, 43.1f},  
        {7.1f, 32.1f},  
        {34.5f, 40.3f},  
        {20.3f, 46.7f},  
        {31.7f, 18.8f},  
        {17.9f, 22.1f},  
        {34.8f, 41.4f},  
        {6.3f, 58.1f},  
        {13f, 39.3f},  
        {20.4f, 23.8f},  
        {13.2f, 34.3f},  
        {35.7f, 50.5f},  
        {0f, 70.1f},  
        {17.7f, 37.4f},  
        {16.9f, 42.3f},  
        {1.5f, 47.7f},  
        {4.5f, 29.3f},  
        {10.5f, 51.6f},  
        {14.7f, 24.6f},  
        {10.1f, 47.9f},  
        {39.6f, 38.8f},  
        {29.3f, 27f},  
        {3.1f, 56.2f},  
        {10.4f, 33.6f},  
        {19.2f, 47f},  
        {7.1f, 57.1f},  
        {25.9f, 22.1f},  
        {29.6f, 25f},  
        {37.9f, 34.2f},  
        {16.5f, 49.3f},  
        {15.4f, 55.1f},  
        {13.9f, 27.3f},  
        {14.7f, 22.9f},  
        {12f, 25.3f},  
        {3.1f, 47.7f},  
        {16.2f, 46.2f},  
        {13.6f, 15.9f},  
        {16.8f, 18.2f},  
        {36.1f, 34.7f},  
        {34.4f, 34.1f},  
        {2.7f, 53.9f},  
        {36.6f, 38.3f},  
        {21.7f, 42f},  
        {35.9f, 61.5f},  
        {24.2f, 13.4f},  
        {29.4f, 13.2f},  
        {21.7f, 44.2f},  
        {31.3f, 20.7f},  
        {32.1f, 27f},  
        {13.3f, 38.9f},  
        {16.1f, 51.7f},  
        {31.7f, 13.7f},  
        {33.6f, 41.9f},  
        {3.5f, 53.5f},  
        {30.3f, 22.6f},  
        {13.3f, 42.4f},  
        {11f, 21.3f},  
        {5.3f, 63.2f},  
        {17.2f, 27.7f},  
        {2.6f, 55f},  
        {17.5f, 25.3f},  
        {40.1f, 44.3f},  
        {1f, 50.7f},  
        {8.5f, 56.8f},  
        {30.4f, 36.2f},  
        {12.5f, 42f},  
        {6.6f, 59f},  
        {35.5f, 40.8f},  
        {32.5f, 36.3f},  
        {13.8f, 20f},  
        {6.8f, 54.4f},  
        {12.3f, 29.5f},  
        {35.9f, 36.8f},  
        {20.5f, 25.6f},  
        {38.2f, 29.8f},  
        {18f, 26.5f},  
        {11.8f, 40.3f},  
        {30.8f, 36.8f},  
        {13.2f, 48.1f},  
        {25.3f, 17.7f},  
        {15.1f, 43.7f},  
        {0f, 50.8f},  
        {1.8f, 27f},  
        {16.9f, 18.3f},  
        {8.9f, 48f},  
        {23f, 25.3f},  
        {0f, 45.4f},  
        {9.1f, 43.2f},  
        {20.6f, 21.8f},  
        {31.9f, 16.1f},  
        {40.9f, 41f},  
        {8f, 51.8f},  
        {6.4f, 59.5f},  
        {28.4f, 34.6f},  
        {16.4f, 51f},  
        {6.4f, 62.2f},  
        {17.5f, 38.2f},  
        {12.7f, 32.9f},  
        {1.1f, 54.4f},  
        {0f, 45.7f},  
        {32.7f, 30.5f},  
        {0f, 71f},  
        {17.2f, 47.1f},  
        {12.2f, 26.6f},  
        {31.4f, 34.1f},  
        {4f, 28.4f},  
        {8.1f, 51.6f},  
        {33.3f, 39.4f},  
        {9.9f, 23.1f},  
        {14.8f, 7.6f},  
        {30.6f, 53.3f},  
        {20.6f, 46.4f},  
        {30.9f, 12.2f},  
        {13.6f, 13f},  
        {25.3f, 30.6f},  
        {16.6f, 59.6f},  
        {13.3f, 31.3f},  
        {13.6f, 48f},  
        {31.5f, 32.5f},  
        {0f, 45.5f},  
        {9.9f, 57.4f},  
        {1.1f, 48.6f},  
        {38.6f, 62.9f},  
        {3.8f, 55f},  
        {41.3f, 60.7f},  
        {38.5f, 41f},  
        {29.6f, 37.5f},  
        {4f, 30.7f},  
        {26.6f, 37.5f},  
        {18f, 39.5f},  
        {33.4f, 42.2f},  
        {18.9f, 20.8f},  
        {11.4f, 46.8f},  
        {13.6f, 47.4f},  
        {10f, 43.5f},  
        {12.9f, 42.5f},  
        {16.2f, 51.4f},  
        {5.1f, 28.9f},  
        {19.8f, 37.5f},  
        {13.6f, 40.1f},  
        {11.9f, 28.4f},  
        {2.1f, 45.5f},  
        {0f, 52.2f},  
        {3.2f, 43.2f},  
        {16.4f, 45.1f},  
        {34.9f, 39.7f},  
        {35.8f, 48.5f},  
        {4.9f, 44.7f},  
        {12f, 28.9f},  
        {6.5f, 40.9f},  
        {16.9f, 20.7f},  
        {13.8f, 15.6f},  
        {30.7f, 18.3f},  
        {16.1f, 35.6f},  
        {11.6f, 39.4f},  
        {15.5f, 37.4f},  
        {3.5f, 57.8f},  
        {19.2f, 39.6f},  
        {16f, 11.6f},  
        {8.5f, 55.5f},  
        {0f, 55.2f},  
        {13.7f, 30.6f},  
        {0f, 73.6f},  
        {28.2f, 43.4f},  
        {27.6f, 37.4f},  
        {8.4f, 23.5f},  
        {24f, 14.4f},  
        {3.6f, 58.8f},  
        {6.6f, 58.1f},  
        {41.3f, 35.1f},  
        {4.3f, 45.2f},  
        {30.2f, 36.5f},  
        {13.9f, 19.2f},  
        {33f, 42f},  
        {13.1f, 36.7f},  
        {14f, 42.6f},  
        {26.9f, 15.5f},  
        {11.6f, 55.9f},  
        {13.5f, 23.6f},  
        {17f, 18.8f},  
        {14.1f, 21.8f},  
        {31.4f, 21.5f},  
        {20.9f, 25.7f},  
        {8.9f, 22f},  
        {34.8f, 44.3f},  
        {16.3f, 20.5f},  
        {35.3f, 42.3f},  
        {13.2f, 37.8f},  
        {43.8f, 42.7f},  
        {9.7f, 49.3f},  
        {15.2f, 29.3f},  
        {15.2f, 34.6f},  
        {22.8f, 36.6f},  
        {34.4f, 48.2f},  
        {34f, 39.1f},  
        {18.2f, 31.6f},  
        {17.4f, 25.5f},  
        {13.1f, 45.9f},  
        {38.3f, 31.5f},  
        {15.6f, 46.1f},  
        {18f, 26.6f},  
        {12.8f, 21.4f},  
        {22.2f, 44f},  
        {38.5f, 34.2f},  
        {11.5f, 26.2f},  
        {34.8f, 40.9f},  
        {5.2f, 52.2f},  
        {0f, 43.5f},  
        {17.6f, 31.1f},  
        {6.2f, 58f},  
        {18.1f, 20.9f},  
        {19.2f, 48.1f},  
        {37.8f, 39.7f},  
        {28f, 40.8f},  
        {13.6f, 43.8f},  
        {29.3f, 40.2f},  
        {37.2f, 78.3f},  
        {9f, 38.5f},  
        {30.6f, 48.5f},  
        {9.1f, 42.3f},  
        {34.5f, 46f},  
        {1.1f, 49f},  
        {16.5f, 12.8f},  
        {32.4f, 40.2f},  
        {11.9f, 46.6f},  
        {31f, 19f},  
        {4f, 33.4f},  
        {16.2f, 14.7f},  
        {27.1f, 17.4f},  
        {39.7f, 32.4f},  
        {8f, 23.9f},  
        {12.9f, 39.3f},  
        {3.6f, 61.9f},  
        {13f, 39f},  
        {12.8f, 40.6f},  
        {18.1f, 29.7f},  
        {11f, 28.8f},  
        {13.7f, 41.4f},  
        {2f, 33.4f},  
        {32.8f, 48.2f},  
        {4.8f, 21.7f},  
        {7.5f, 40.8f},  
        {16.4f, 40.6f},  
        {21.7f, 23.1f},  
        {19f, 22.3f},  
        {18f, 15f},  
        {39.2f, 30f},  
        {31.7f, 13.8f},  
        {5.9f, 52.7f},  
        {30.4f, 25.9f},  
        {1.1f, 51.8f},  
        {31.5f, 17.4f},  
        {14.6f, 26.5f},  
        {17.3f, 43.9f},  
        {0f, 63.3f},  
        {17.7f, 28.8f},  
        {17f, 30.7f},  
        {16.2f, 24.4f},  
        {15.9f, 53f},  
        {3.9f, 31.7f},  
        {32.6f, 40.6f},  
        {15.7f, 38.1f},  
        {17.8f, 23.7f},  
        {34.7f, 41.1f},  
        {17.2f, 40.1f},  
        {17.6f, 23f},  
        {10.8f, 117.5f},  
        {17.7f, 26.5f},  
        {13f, 40.5f},  
        {13.2f, 29.3f},  
        {27.5f, 41f},  
        {1.5f, 49.7f},  
        {19.1f, 34f},  
        {21.2f, 27.7f},  
        {0f, 44f},  
        {2.6f, 31.1f},  
        {2.3f, 45.4f},  
        {4.7f, 44.8f},  
        {2f, 25.6f},  
        {33.5f, 23.5f},  
        {15f, 34.4f},  
        {30.1f, 55.3f},  
        {5.9f, 56.3f},  
        {19.2f, 32.9f},  
        {16.6f, 51f},  
        {13.9f, 44.5f},  
        {37.7f, 37f},  
        {3.4f, 54.4f},  
        {17.5f, 24.5f},  
        {12.6f, 42.5f},  
        {26.4f, 38.1f},  
        {18.2f, 21.8f},  
        {12.5f, 34.1f},  
        {34.9f, 28.5f},  
        {16.7f, 16.7f},  
        {33.2f, 46.1f},  
        {2.5f, 36.9f},  
        {38f, 35.7f},  
        {16.5f, 23.2f},  
        {38.3f, 38.4f},  
        {20f, 29.4f},  
        {16.2f, 55f},  
        {14.4f, 50.2f},  
        {10.3f, 24.7f},  
        {16.4f, 53f},  
        {30.3f, 19.1f},  
        {16.4f, 24.7f},  
        {21.3f, 42.2f},  
        {35.4f, 78f},  
        {8.3f, 42.8f},  
        {3.7f, 41.6f},  
        {15.6f, 27.3f},  
        {13.3f, 42f},  
        {15.6f, 37.5f},  
        {7.1f, 49.8f},  
        {34.6f, 26.9f},  
        {13.5f, 18.6f},  
        {16.9f, 37.7f},  
        {12.9f, 33.1f},  
        {28.6f, 42.5f},  
        {12.4f, 31.3f},  
        {36.6f, 38.1f},  
        {4.1f, 62.1f},  
        {3.5f, 36.7f},  
        {15.9f, 23.6f},  
        {13.6f, 19.2f},  
        {32f, 12.8f},  
        {25.6f, 15.6f},  
        {39.8f, 39.6f},  
        {7.8f, 38.4f},  
        {30f, 22.8f},  
        {27.3f, 36.5f},  
        {5.1f, 35.6f},  
        {31.3f, 30.9f},  
        {31.5f, 36.3f},  
        {1.7f, 50.4f},  
        {33.6f, 42.9f},  
        {13f, 37f},  
        {5.7f, 53.5f},  
        {33.5f, 46.6f},  
        {34.6f, 41.2f},  
        {0f, 37.9f},  
        {13.2f, 30.8f},  
        {17.4f, 11.2f},  
        {4.6f, 53.7f},  
        {7.8f, 47f},  
        {13.2f, 42.3f},  
        {4f, 28.6f},  
        {18.4f, 25.7f},  
        {4.1f, 31.3f},  
        {12.2f, 30.1f},  
        {3.8f, 60.7f},  
        {10.3f, 45.3f},  
        {0f, 44.9f},  
        {1.1f, 45.1f},  
        {5.6f, 24.7f},  
        {32.9f, 47.1f},  
        {41.4f, 63.3f},  
        {17.1f, 40f},  
        {32.3f, 48f},  
        {35.3f, 33.1f},  
        {17.3f, 29.5f},  
        {14.2f, 24.8f},  
        {15f, 20.9f},  
        {18.2f, 43.1f},  
        {20.2f, 22.8f},  
        {15.9f, 42.1f},  
        {4.1f, 51.7f},  
        {33.9f, 41.5f},  
        {0f, 52.2f},  
        {5.4f, 49.5f},  
        {21.7f, 23.8f},  
        {14.7f, 30.5f},  
        {3.9f, 56.8f},  
        {37.3f, 37.4f},  
        {0f, 69.7f},  
        {14.1f, 53.3f},  
        {8f, 47.3f},  
        {16.3f, 29.3f},  
        {29.1f, 40.3f},  
        {16.1f, 12.9f},  
        {18.3f, 46.6f},  
        {0f, 55.3f},  
        {16.2f, 25.6f},  
        {10.4f, 27.3f},  
        {40.9f, 67.7f},  
        {32.8f, 38.6f},  
        {6.2f, 31.3f},  
        {42.7f, 35.3f},  
        {16.9f, 40.3f},  
        {32.6f, 24.7f},  
        {21.2f, 42.5f},  
        {37.1f, 31.9f},  
        {13.1f, 32.2f},  
        {14.7f, 23f},  
        {12.7f, 37.3f},  
        {26.8f, 35.5f},  
        {7.6f, 27.7f},  
        {12.7f, 28.5f},  
        {30.9f, 39.7f},  
        {16.4f, 41.2f},  
        {23f, 37.2f},  
        {1.9f, 40.5f},  
        {5.2f, 22.3f},  
        {18.5f, 28.1f},  
        {13.7f, 15.4f},  
        {5.6f, 50f},  
        {18.8f, 40.6f},  
        {8.1f, 52.5f},  
        {6.5f, 63.9f}
    };

    LinearRegression model = new LinearRegression();
    for(int i = 0; i <= 413; i++)
    {
        model.train(datas[i, 0], datas[i, 1]);
    }

    float exam = model.guess(19.5f);
    Console.WriteLine(exam);
    

  }
}