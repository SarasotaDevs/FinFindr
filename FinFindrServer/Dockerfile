# Use the SDK image because 'dotnet run' requires build tools
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS runtime
WORKDIR /app

# Copy all project files
COPY . .

# Restore dependencies
RUN dotnet restore

# Expose the port the app will run on
EXPOSE 8080

# Run the application using 'dotnet run'
CMD ["dotnet", "run", "--urls", "http://0.0.0.0:8080"]
