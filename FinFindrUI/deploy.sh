#!/bin/bash

# Variables
BUCKET_NAME="www.finfindr.org"
BUILD_DIR="dist"
REGION="us-east-2"

# Step 1: Build the Vite project
echo "Building the Vite project..."
npm run build

# Step 2: Sync the build output to the S3 bucket
echo "Deploying to S3 bucket: $BUCKET_NAME"
aws s3 sync $BUILD_DIR s3://$BUCKET_NAME/ --region $REGION --delete

# Step 3: Set the S3 bucket as a static website
echo "Setting S3 bucket to static website mode..."
aws s3 website s3://$BUCKET_NAME/ --index-document index.html --error-document index.html

echo "Deployment complete!"
