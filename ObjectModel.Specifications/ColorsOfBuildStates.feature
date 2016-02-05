Feature: Colors Of Build States

Scenario Outline: The colors that correspond to single build states

    Given the build state is '<state>'
    When I turn on the light
    Then the light is '<color>'

    Examples:
        
        | state   | color |
        | Success | Green |

