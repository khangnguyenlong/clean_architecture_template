# Clean Architecture Template

What's included in the template?

- SharedKernel project with common Domain-Driven Design abstractions.
- Domain layer with a sample entity.
- Application layer with abstractions for:
    - CQRS
    - Caching
    - Event bus
    - Cross-cutting concerns (logging, exception handling, transactions, caching, validation)
- Infrastructure layer with:
    - Permission authorization
    - Outbox pattern using Hangfire
    - SQL, EF Core, Caching, Repositories
    - In-memory event bus for publishing integration events
- Hangfire for background jobs
    - Hangfire Dashboard is available at https://localhost:5001/hangfire by default
- Seq for searching and analyzing structured logs
    - Seq is available at http://localhost:8081 by default
- Aspire Dashboard for monitoring traces, metrics, and logs.
    - Available at http://localhost:18888 by default
- Testing projects
    - Unit testing
    - Integration testing
    - Functional testing
    - Architecture testing

I'm open to hearing your feedback about the template and what you'd like to see in future iterations.

Stay awesome!
