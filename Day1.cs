﻿using System;
using System.IO;

public class Day1
{
    StreamWriter inputFile;
    int sumOfValues;
    int maxValue;

    static void main(string? fileName)
	{
        if (fileName == null) return;

        inputFile = new StreamWriter(fileName);
        sumOfValues = 0;
        maxValue = 0;

        while (inputFile.CanSeek)
        {
            if (inputFile.ReadLine() == "")
        }

	}
}