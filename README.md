### Assignment Description

**Title:** Database Model Design and User Interface (UI) for a Business Management System

**Objective:**  
Develop a data model and corresponding user interface for a Inventory Management System. 
The system should support essential business operations like managing user registrations, products, vendors, customers,
purchases, and units within an organization. Additionally, design elements to streamline operations by allowing users to 
submit multiple entries at once, enhancing the overall efficiency and usability.

---

### Requirements

1. **Data Models:**
   - **User Registration:**
     - **Company**  
       - `cid`: Unique identifier for the company  
       - `name`, `addr`, `phone`, `email`, `fax`, `PAN number`, `website`: Key contact and identification details of the company  
     - **User**  
       - `uid`: Unique identifier for the user  
       - `cid`: Company ID the user belongs to  
       - `username`, `address`, `phone number`, `email`, `password`, `approved`: User details and status in the system  

   - **Unit**  
     - `uid`, `companyid`, `userid`: Unique identifiers to associate the unit with specific users and companies  
     - `unit_name`, `description`: Core details about each unit  

   - **Product Group**  
     - `pgid`, `cid`, `uid`: Identifiers to link each product group with users and companies  
     - `groupname`, `description`: Core information about each product group  

   - **Product Sub Group**  
     - `pgsubid`, `groupname`, `description`, `cid`, `uid`, `pgid`: Details of product subgroups within each product group  

   - **Product**  
     - `pid`, `cid`, `uid`, `subgroupid`, `unitid`: Identifiers to associate products with subgroups, units, users, and companies  
     - `name`, `description`, `quantity`, `rate`: Core details about each product  

   - **Vendor**  
     - `name`, `addr`, `email`, `uid`, `cid`: Basic vendor information  

   - **Customer**  
     - `name`, `addr`, `email`, `uid`, `cid`: Basic customer information  

   - **Purchase**  
     - `id`, `cid`, `uid`, `productid`, `unitid`: Purchase details to record purchases by linking products and units  

2. **User Interface Requirements:**
   - **Support Multiple Entries for Sales and Purchase:**  
     Design the UI to allow users to add several entries for sales and purchases in one submission to reduce data entry time.

   - **CRM Integration:**  
     Include a **Customer Relationship Management (CRM)** component, focusing on:
     - **Employee Management**: An employee database with department identifiers to categorize employees.  

   - **Dropdown Menus:**  
     Provide dropdown menus where necessary to simplify data selection, such as for `departments`, `product groups`, and `units`.

---

### Deliverables:
- **ER Diagram:** An entity-relationship diagram illustrating all entities, their attributes, and relationships.
- **Database Schema:** Create and present the schema for each model, including primary keys, foreign keys, and necessary constraints.
- **UI Mockups:** Wireframes or prototypes for the following:
  - User registration form
  - Multiple-entry sales and purchase submission form
  - CRM interface with employee department dropdown
