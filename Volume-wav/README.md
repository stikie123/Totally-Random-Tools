## README for C Program
### Description  
This C program adjusts the volume of a WAV audio file by a specified factor.  
#### Usage  
bash
``` 

./volume input.wav output.wav factor
```
- input.wav: Path to the input WAV file.
- output.wav: Path to the output WAV file.
- factor: Volume scaling factor (e.g., 1.5 to increase volume by 50%).
#### Compilation
bash
````
gcc -o volume volume.c
````
#### Example
bash
````
./volume input.wav output.wav 1.5
````
## README for C# Program
### Description
This C# program modifies the volume of a WAV audio file by a specified factor.
#### Usage
bash
````
dotnet run <input.wav> <output.wav> <factor>
````
- input.wav: Path to the input WAV file.
- output.wav: Path to the output WAV file.
- factor: Volume scaling factor (e.g., 1.5 to increase volume by 50%).
### Setup and Compilation
#### 1. Create a new .NET Core console project:
bash
````
dotnet new console -n VolumeModifier
````
#### 2. Place Program.cs in the VolumeModifier directory.
#### 3. Navigate to the project directory:
bash
```
cd VolumeModifier
```
#### 4.Run the program:
bash
```
dotnet run <input.wav> <output.wav> <factor>
```
#### Example
bash
```
dotnet run input.wav output.wav 1.5
```
