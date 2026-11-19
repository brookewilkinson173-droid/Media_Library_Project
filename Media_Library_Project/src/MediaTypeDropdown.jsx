
import { useEffect, useState } from "react";

const mediaTypeLabels = {
  Book: "Books",
  Song: "Songs",
  Movie: "Movies",
  TVShow: "Shows",
};
const fallbackMediaTypes = ["Book", "Song", "Movie", "TVShow"];

function MediaTypeDropdown({ value, onChange }) {
  const [mediaTypes, setMediaTypes] = useState(fallbackMediaTypes);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState("");

  useEffect(() => {
    async function fetchMediaTypes() {
      try {
        const response = await fetch("/api/media-attributes/media-types");

        if (!response.ok) {
          throw new Error(`HTTP error: ${response.status}`);
        }

        const data = await response.json();
        setMediaTypes(data);
      } catch (err) {
        setError(
          "Failed to load media types. Check that the backend is running."
        );
        console.error("Error fetching media types:", err);
      } finally {
        setLoading(false);
      }
    }

    fetchMediaTypes();
  }, []);

  return (
    <div className="media-type-filter">
      <select
        id="mediaType"
        aria-label="Filter by media type"
        value={value}
        onChange={onChange}
      >
        <option value="All Media">All Media</option>

        {mediaTypes.map((medium) => (
          <option key={medium} value={medium}>
            {mediaTypeLabels[medium] || medium}
          </option>
        ))}
      </select>

      {loading && <span className="media-type-status">Loading media types...</span>}
      {error && (
        <span className="media-type-error" role="alert">
          {error}
        </span>
      )}
    </div>
  );
}

export default MediaTypeDropdown;
