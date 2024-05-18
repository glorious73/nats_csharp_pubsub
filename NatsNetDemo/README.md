# NATS Pub/Sub C# Clients
This repository contains a publisher and a subscriber to the NATS server.

## Purpose
Demonstrate the ability to use [NATS](https://nats.io/) Pub/Sub in distributed systems.

## How to run
1. Install NATS on your machine and run the nats server. [Docs can be found here](https://docs.nats.io/running-a-nats-service/introduction/installation).
2. Clone the repository.
3. Hit `dotnet build` on a terminal window in the project root.
4. Run `dotnet run` in the same project root.
5. Publish a message using the `nats cli` or a another publisher.
6. Go back to the subscriber terminal window and confirm receiving the published message.

## Interoperability
There is [another repository](https://github.com/glorious73/nats_js_pubsub) that has a Node.js client to NATS which has a publisher that can publish messages to this one.

## References
- [NATS Documentation](https://docs.nats.io/nats-concepts/subjects).
- [NATS.Net Documentation](https://nats-io.github.io/nats.net.v2/documentation/intro.html?tabs=core-nats).