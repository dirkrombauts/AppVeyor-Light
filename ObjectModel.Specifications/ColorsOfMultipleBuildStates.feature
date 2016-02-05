Feature: Colors Of Multiple Build States
When multiple builds are present, either on a single project or on multiple projects,
we need to calculate one single color that will be shown on the light.

Scenario: When there is a build in progress, the color is yellow
A build in progress is more important than anything else

Given I have these projects and build states
    | Project   | Build State |
    | Project A | Success     |
    | Project B | Queued      |
    | Project C | Failed      |
    | Project D | Running     |
When I turn on the light
Then the light is 'Yellow'
