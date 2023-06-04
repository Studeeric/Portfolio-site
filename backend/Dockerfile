# Base image
FROM mcr.microsoft.com/dotnet/sdk:latest

# Set working directory
WORKDIR /app

# Copy the backend project files
COPY *.csproj ./

# Restore dependencies
RUN dotnet restore

# Copy the rest of the backend code
COPY . .

# Build the backend application
RUN dotnet build -c Release --no-restore

# Expose the desired port (adjust if necessary)
EXPOSE 5000

# Command to start the backend application
CMD ["dotnet", "run", "--project", "backend.csproj"]
