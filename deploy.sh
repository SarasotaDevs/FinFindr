#!/bin/bash

# Define your variables
S3_BUCKET_NAME="www.finfindr.org"
BUILD_DIR="FinFindrUI/"
AWS_REGION="us-east-2" # e.g., us-east-1


# Check if the build directory exists
if [ ! -d "$BUILD_DIR" ]; then
  echo "Error: Build directory '$BUILD_DIR' does not exist. Run 'expo build:web' first."
  exit 1
fi

# Sync the web build files to the S3 bucket
echo "Deploying to S3 bucket: $S3_BUCKET_NAME..."
aws s3 sync $BUILD_DIR s3://$S3_BUCKET_NAME --region $AWS_REGION --delete

# Set the correct permissions for web hosting
echo "Setting S3 bucket permissions..."
aws s3 website s3://$S3_BUCKET_NAME --index-document index.html --error-document index.html

echo "Deployment to S3 completed successfully!"
