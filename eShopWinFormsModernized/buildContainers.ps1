docker-compose stop
docker-compose -f docker-compose.yml -f docker-compose.override.yml build
docker-compose up -d