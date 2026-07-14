---
name: LegalWorkflowSkill
description: Use this skill when analyzing NDAs or validating contract compliance rules.
---
# Contract Validation Guidelines
1. Check for explicit jurisdiction declarations.
2. Cross-reference defined terms against compliance_doc.json.


# File-Based Skill File Layout

This document details the optional file-based skill directory layout used by `AgentSkillsProvider` when configuration paths are resolved via `UseFileSkill`.

### Directory Structure

```text
SkillsLibrary/
│
└───LegalWorkflowSkill/
        SKILL.md                 <-- Contains frontmatter metadata and core instructions
        references/
            compliance_doc.json  <-- Loaded via read_skill_resource tool


            
```

**Lookup tables** are in references/ subdirectory.   
The host model will only fetch this data dynamically via read_skill_resource 
when the user prompt triggers it.


~~Old Ollama Framework Hook~~ -> `UseFileSkill()` API
This is ***extremely important*** to remember.
This is ___also valid syntax___.




> This is the first paragraph of an alert callout.
>
> This is the second paragraph inside the exact same callout block.

<details>
<summary>Click here to expand the SKILL.md layout configuration</summary>

### Hidden Content
This remains collapsed by default to save screen real estate.

</details>

1.  Initialize the Ollama instance.
    Make sure your local server is running on port 11434.
2.  Inject the Skills Provider.

- [x] Configure `AgentSkillsProviderBuilder`
- [ ] Add JSON serialization validation rules
- [ ] Run test scripts against local Llama model
- [ ] XYZ



| Left-Aligned | Center-Aligned | Right-Aligned |
| :---         |     :---:      |          ---: |
| Default rule | Balanced text  | $1,250.00     |


| Skill Name | Requirements & Descriptions |
| :--- | :--- |
| `LegalWorkflow` | 1. Parse NDAs<br>2. Extract entities<br>3. Flag liabilities |



| Method | Implementation Example |
| :--- | :--- |
| `UseInMemorySkills` | <pre><code>var skill = new AgentInlineSkill(<br>  name: "DataSkill",<br>  content: "Format raw logs"<br>);</code></pre> |



<table>
  <tr>
    <th>Module</th>
    <th colspan="2">Supported Providers</th>
  </tr>
  <tr>
    <td>AgentAI</td>
    <td>Ollama</td>
    <td>OpenAI</td>
  </tr>
</table>


| Provider | Supported Features |
| :--- | :--- |
|  **Ollama**|   <ul><li>Local execution</li><li>Custom system prompts</li><li>Tool calling (select models)</li></ul> |






```csharp
    
```




```JSON



{
  "mandatory_clauses": [
    "Governing Law",
    "Severability",
    "Term and Termination"
  ],
  "prohibited_terms": [
    "Uncapped Liability",
    "Automatic Perpetual Renewal"
  ],
  "default_jurisdiction": "Australian Capital Territory"
}
