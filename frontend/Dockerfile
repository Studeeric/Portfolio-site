# Base image
FROM node:14-alpine

# Set working directory
WORKDIR /app

# Copy package.json and package-lock.json
COPY package*.json ./

# Install dependencies
RUN npm install

# Copy the rest of the frontend code
COPY . .

# Build the frontend application
RUN npm run build

# Expose the desired port (adjust if necessary)
EXPOSE 3000

# Command to start the frontend application
CMD ["npm", "start"]
