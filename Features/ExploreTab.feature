Feature: ExploreTab

This Feature File has all scenarios related to Trending page in Youtube site

Scenario Outline: Verify all the Trending pages for each Content Type
When Go To <ContentType> in Explore Tab from Home Page
Then Verify user can see the <ContentType> page
Examples:
| ContentSection   |
| Shopping         |
| Music            |
| Movies           |
| Live             |
| Gaming           |
| News             |
| Sports           |
| Courses          |
| Fashion & Beauty |
| Podcasts         |

