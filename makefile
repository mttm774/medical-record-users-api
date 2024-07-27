docker-up:
	docker compose up --build

docker-down:
	docker compose down

docker-dev-up:
	docker compose -f docker-compose.develop.yaml up --build

docker-dev-down:
	docker compose -f docker-compose.develop.yaml down

build:
	dotnet build

run:
	dotnet run --project ./medical-record-users-api/medical-record-users-api.csproj