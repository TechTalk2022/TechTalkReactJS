
import {
    BrowserRouter,
    Routes,
    Route,
} from "react-router-dom";

import AddCustomerDirectory from "../areas/administration/CustomerDirectory/addcustomerdirectory";
import ViewCustomerDirectory from "../areas/administration/CustomerDirectory/viewcustomerdirectory";
import Dashborad from "./home/dashborad";
import Footer from "./layout/footer";
import Header from "./layout/header";

// import your route components too
const URLRouter = () => {
    return (
        <BrowserRouter>

            <Header />
            <Routes>
                <Route path="/" element={<Dashborad />} />
                <Route path="/dashborad" element={<Dashborad />} />

                <Route path="/add-customer" element={<AddCustomerDirectory />} />
                <Route path="/view-customer" element={<ViewCustomerDirectory />} />

            </Routes>
            <Footer />

        </BrowserRouter>
    );
}

export default URLRouter;
