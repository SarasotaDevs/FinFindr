./buildImages.sh

cd FinFindrUI

./deploy.sh

cd ../server/dev-environment

docker-compose down
docker-compose up -d