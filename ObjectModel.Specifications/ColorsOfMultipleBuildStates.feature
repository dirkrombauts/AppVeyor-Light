Feature: Colors Of Multiple Build States
When multiple builds are present, either on a single project or on multiple projects,
we need to calculate one single color that will be shown on the light.

We consider the builds in order of (descending) precedence to determine the color:

1. Running
2. Queued
3. Failed
4. Cancelled
5. Unknown
6. Success

Scenario: When there is a build in progress, the color is yellow
A build in progress is more important than anything elsel

Given I have these projects and build states
    | Project   | Build State |
    | Project A | Success     |
    | Project B | Queued      |
    | Project C | Failed      |
    | Project D | Running     |
When I turn on the light
Then the light is 'Yellow'


Scenario: When there is no build in progress but there is one scheduled, the color is blue
A scheduled build is more important than anything else apart from a build in progress.

Given I have these projects and build states
    | Project   | Build State |
    | Project A | Success     |
    | Project B | Queued      |
    | Project C | Failed      |
When I turn on the light
Then the light is 'Blue'


Scenario: When there are no build in progressed or scheduled, but there is a failed build, the color is red

A failed build is more important than a cancelled, unknown or successfull one, but
less important than a running or queued build.

Given I have these projects and build states
    | Project   | Build State |
    | Project A | Success     |
    | Project B | Unknown     |
    | Project C | Failed      |
    | Project D | Cancelled   |
When I turn on the light
Then the light is 'Red'


Scenario: A cancelled build is more important than an unknown or a successful one

Given I have these projects and build states
    | Project   | Build State |
    | Project A | Success     |
    | Project B | Unknown     |
    | Project D | Cancelled   |
When I turn on the light
Then the light is 'White'


Scenario: An unknown build is more important than a successful one

Given I have these projects and build states
    | Project   | Build State |
    | Project A | Success     |
    | Project B | Unknown     |
When I turn on the light
Then the light is 'White'


Scenario: We have green light only if all projects have a successful build

Given I have these projects and build states
    | Project   | Build State |
    | Project A | Success     |
    | Project B | Success     |
    | Project C | Success     |
    | Project D | Success     |
When I turn on the light
Then the light is 'Green'

